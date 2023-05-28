using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Player : MonoBehaviour
{
    CharacterController characterController; //Componente que controla o jogador
    Animator animator;

    public float speed = 6.0f; //Velocidade de movimento, definível no Inspector
    public float jumpSpeed = 8.0f; //Velocidade de salto, definível no Inspector
    public float gravity = 0f; //Gravidade, definível no Inspector

    private Vector3 moveDirection = Vector3.zero; //Vector que controla a direcção do movimento
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>(); //Ir buscar o componente ao gameObject
        animator = GetComponent<Animator>(); // Obtém o componente Animator anexado ao GameObject
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.isGrounded) //Se a personagem estiver no chão
            {
            // We are grounded, so recalculate
            // move direction directly from axes
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f,
            Input.GetAxis("Vertical")); //Ir buscar os valores do eixo horizontal (A/D ou seta esquerda/direita) e do eixo vertical (W/S ou seta frente e trás)
            moveDirection *= speed; //Multiplicar este vector pela variável de velocidade definida no início do script
            if (Input.GetButton("Jump")) //Se a pessoa carregar na tecla de saltar (barra de espaço)
                {
                moveDirection.y = jumpSpeed; //Adicionar velocidade no eixo Y, que até ao momento está definido com 0 (ver moveDirection)
                }

                // Verifica a magnitude do movimento para determinar a velocidade da animação
            float movementMagnitude = moveDirection.magnitude;
            animator.SetFloat("Speed", movementMagnitude); // Define o parâmetro "Speed" do Animator

            // Verifica se o personagem está parado (magnitude do movimento próxima de zero)
            if (movementMagnitude < 0.1f)
            {
                animator.SetBool("Z_Walking_InPlace", false); // Define o parâmetro bool "Z_Walking_InPlace" como falso
            }
            else
            {
                animator.SetBool("Z_Walking_InPlace", true); // Define o parâmetro bool "Z_Walking_InPlace" como verdadeiro
            }

            moveDirection = transform.TransformDirection(moveDirection);
            }
            // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
            // as an acceleration (ms^-2)
            moveDirection.y -= gravity * Time.deltaTime;
            // Move the controller
            characterController.Move(moveDirection * Time.deltaTime);

    }
}
