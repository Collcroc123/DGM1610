using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 positionDirection = Vector3.zero;
    private float gravity = 75f;
    public float speed = 10f;
    public float jumpForce = 0.5f;
    private int maxJump = 2;
    private int jumpCount = 1;

    //https://docs.unity3d.com/ScriptReference/CharacterController.Move.html

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        //Moving
        positionDirection.x = Input.GetAxis("Horizontal") * speed;
        positionDirection.z = Input.GetAxis("Vertical") * speed;
        positionDirection.y -= gravity * Time.deltaTime;
        controller.Move(positionDirection * Time.deltaTime);

        //Jumping
        if (Input.GetButtonDown("Jump"))
        {
            if (jumpCount < maxJump)
            {
                positionDirection.y = jumpForce;
                jumpCount++;
            }
        }
        if (controller.isGrounded)
        {
            jumpCount = 1;
        }

        //Running
        if (Input.GetButton("Run"))
        {
            speed = 15f;
        }
        else
        {
            speed = 10f;
        }    
    }
}
