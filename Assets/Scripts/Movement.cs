using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	[SerializeField] private byte	speed;
	[SerializeField] private byte	jumpForce;

	float   horizontalInput;
	float   verticalInput;
	bool    isJumpInput = false;
	bool    isGrounded = true;

	Vector3 moveDirection;

	Rigidbody rb;

    // Fixed Update independent from FPS
    private void FixedUpdate()
    {
        MovePlayer();
        Grounded();

        if (isJumpInput && isGrounded)
		{
			rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
		}

    }

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();
    }

	// Update is called once per frame
	void Update()
    {
        MyInput();

		if (Input.GetKey(KeyCode.Space))
        {
            isJumpInput = true;
        }
        else
        {
			isJumpInput = false;
        }
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void MovePlayer()
    {
        moveDirection = (transform.forward * verticalInput + transform.right * horizontalInput).normalized;
        var velo = (moveDirection * speed);
        rb.velocity = new Vector3(velo.x, rb.velocity.y, velo.z);
    }

    private void Grounded()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, -transform.up, out hit, 1f))
        {
            if(hit.distance <= 0.1f)
            {
                isGrounded = true;
            }
            else
            {
                isGrounded = false;
            }
        }
    }
    
}
