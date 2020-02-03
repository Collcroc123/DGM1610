using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 positionDirection;
    private float gravity = -1f;
    public float speed = 5f;
    public float jumpForce = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        positionDirection.x = Input.GetAxis("Vertical")*speed;
        positionDirection.y += gravity;
        positionDirection.z = Input.GetAxis("Horizontal")*-speed;
        controller.Move(positionDirection*Time.deltaTime);

        if(Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            positionDirection.y = jumpForce;
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
