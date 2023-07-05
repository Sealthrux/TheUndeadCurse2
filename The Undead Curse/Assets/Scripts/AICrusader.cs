using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICrusader : MonoBehaviour
{
    enum State
    {
        Roam,
        Chasing,
        Attack,
        Dead
    };

    public float RoamRadius = 20f;
    float chaseRange = 25f;
    float attackRange = 10f;

    bool WalkPointSet;
    bool Attacked;
    bool Kill = false;

    Vector3 destiny = new Vector3();
    Vector3 startPosition;
    Vector3 WalkPoint;

    RaycastHit tempInfo;

    List<Transform> wayPoints = new List<Transform>();

    [SerializeField]
    private Animator Animator;

    [SerializeField]
    private UnityEngine.AI.NavMeshAgent agent;

    [SerializeField]
    private LayerMask GroundMask;

    [SerializeField]
    State PlayerState;

    [SerializeField]
    float WalkSpeed,
        RunSpeed;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        Animator = agent.GetComponent<Animator>();

        GameObject go = GameObject.FindGameObjectWithTag("WayPoints");
        foreach (Transform t in go.transform)
            wayPoints.Add(t);

        agent.SetDestination(wayPoints[Random.Range(0, wayPoints.Count)].position);
    }

    // Update is called once per frame
    void Update()
    {
        destiny = GameManager.instance.Player.transform.position;

        // Verificar se está vivo ou se está morto
        if (100 <= 0)
        {
            PlayerState = State.Dead;
        }
        // Se houver distância suficiente, haverá um ataque
        else if (Vector3.Distance(transform.position, destiny) <= attackRange)
        {
            PlayerState = State.Attack;
        }
        // Se a distância não for suficiente para o ataque, verifica se é suficiente para o inimigo se aproximar
        else if (Vector3.Distance(transform.position, destiny) <= chaseRange)
        {
            PlayerState = State.Chasing;
        }
        // Se não houver mais nenhuma condição ele irá caminhar/vaguear
        else
        {
            PlayerState = State.Roam;
        }
        HandleBehaviour();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(WalkPoint, .5f);
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

    void HandleBehaviour()
    {
        switch (PlayerState)
        {
            case State.Dead:
                Dead();
                break;
            case State.Attack:
                Attack();
                break;
            case State.Chasing:
                Chasing();
                break;
            case State.Roam:
                Roam();
                break;
            default:
                Debug.LogError("Player state não reconhecido");
                break;
        }
    }

    void Dead()
    {
        if (Kill)
            return;
        Kill = true;
        Animator.SetTrigger("isDead");
    }

    void Attack()
    {
        Animator.SetBool("isAttacking", true);
        agent.SetDestination(transform.position);
        Vector3 direction = (destiny - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5);

        if (!Attacked)
        {
            Attacked = true;
        }
    }

    public void ResetAttack()
    {
        Attacked = false;
    }

    void Chasing()
    {
        agent.speed = RunSpeed;
        Animator.SetBool("isChasing", true);
        Animator.SetBool("isAttacking", false);
        agent.SetDestination(destiny);
        Vector3 direction = (destiny - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime);
    }

    void Roam()
    {
        agent.speed = WalkSpeed;
        Animator.SetBool("isAttacking", false);
        Animator.SetBool("isChasing", false);
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            Debug.Log("Reached waypoint, setting new destination.");
            agent.SetDestination(wayPoints[Random.Range(0, wayPoints.Count)].position);
        }
    }

    void GetNewWayPoint()
    {
        float rz = Random.Range(-RoamRadius + 1f, RoamRadius - 1f);
        float rx = Random.Range(-RoamRadius + 1f, RoamRadius - 1f);
        float ry = 10f;

        WalkPoint = new Vector3(startPosition.x + rx, startPosition.y + ry, startPosition.z + rz);
        if (Physics.Raycast(WalkPoint, Vector3.down, out tempInfo, 25f, GroundMask))
        {
            WalkPoint = tempInfo.point;
            WalkPointSet = true;
            //Debug.Log(WalkPoint + ": waypoint");
        }
        else
        {
            //Debug.Log(gameObject.name + ": couldnt find path");
        }
    }
}
