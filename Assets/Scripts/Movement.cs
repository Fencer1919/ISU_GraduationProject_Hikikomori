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
		moveDirection.y = rb.velocity.y;
		rb.velocity = (moveDirection * speed);
	}

	// Update is called once per frame
	/*
	void Update()
    {
		if (Input.GetKey(KeyCode.D))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.W))
		{
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.position += Vector3.back * speed * Time.deltaTime;
		}
        if (Input.GetKey(KeyCode.Space))
        {
			transform.position += Vector3.up * speed * Time.deltaTime;
        }
	}*/
}
