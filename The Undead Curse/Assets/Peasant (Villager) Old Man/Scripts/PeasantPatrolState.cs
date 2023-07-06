using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PeasantPatrolState : StateMachineBehaviour
{
    float timer;
    List<Transform> wayPoints = new List<Transform>();
    NavMeshAgent agent;

    Transform player;
    float chaseRange = 40;

    override public void OnStateEnter(
        Animator animator,
        AnimatorStateInfo stateInfo,
        int layerIndex
    )
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        agent = animator.GetComponent<NavMeshAgent>();
        agent.speed = 5.5f;
        timer = 0;
        GameObject go = GameObject.FindGameObjectWithTag("WayPointsPeasant1");
        foreach (Transform t in go.transform)
            wayPoints.Add(t);
        Vector3 testeV = wayPoints[Random.Range(0, wayPoints.Count)].position;
        Debug.Log(animator.transform.position +" "+ testeV);
        agent.SetDestination(testeV);
    }

    override public void OnStateUpdate(
        Animator animator,
        AnimatorStateInfo stateInfo,
        int layerIndex
    )
    {
        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            Debug.Log("Reached waypoint, setting new destination.");
            agent.SetDestination(wayPoints[Random.Range(0, wayPoints.Count)].position);
        }
        
        timer += Time.deltaTime;
        if (timer > 5)
            animator.SetBool("isPatrolling", false);

        float distance = Vector3.Distance(player.position, animator.transform.position);
        if (distance < chaseRange)
        {
            animator.SetBool("isChasing", true);
        }
    }

    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        agent.SetDestination(agent.transform.position);
    }

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
