using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 positionDirection;
    private float gravity = -0.5f;
    public float speed = 5f;
    public float jumpForce = 10f;
    private int maxJump = 2;
    private int currentJump = 1;

    void Start()
    {
        
    }

    void Update()
    {
        positionDirection.x = Input.GetAxis("Vertical")*speed;
        positionDirection.y += gravity;
        positionDirection.z = Input.GetAxis("Horizontal")*-speed;
        controller.Move(positionDirection*Time.deltaTime);

        if(Input.GetButtonDown("Jump"))
        {
            if(currentJump < maxJump)
            {
                positionDirection.y = jumpForce;
                currentJump++;
            }
        }
        if(controller.isGrounded)
        {
            currentJump = 1;
        }

        if (Input.GetButton("Run"))
        {
            speed = 10f;
        }
        else
        {
            speed = 5f;
        }
    }
}
