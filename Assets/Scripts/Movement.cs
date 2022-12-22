using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	[SerializeField] private byte	speed;
	[SerializeField] private byte	jumpForce;

	float horizontalInput;
	float verticalInput;
	
	Vector3 moveDirection;

	Rigidbody rb;

    // Fixed Update independent from FPS
    private void FixedUpdate()
    {
		MyInput();
		MovePlayer();
		
		if (Input.GetButtonDown("Jump"))
		{
			rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
		}
	}

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();
		rb.freezeRotation = true;
    }

	private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

	private void MovePlayer()
	{
		moveDirection = (transform.forward * verticalInput + transform.right * horizontalInput).normalized;
		var velo = (moveDirection * speed);
		rb.velocity = new Vector3(velo.x, rb.velocity.y, velo.z);
	}

	// Update is called once per frame
	void Update()
    {
		
	}
}
