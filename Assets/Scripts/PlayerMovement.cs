using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	public float speed;

	private Rigidbody rb;

	void Start ()
	{
		
	}

	void OnTriggerEnter(Collider other) 
	{
		
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

		GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);

		{
			if (Input.GetKeyDown ("space") && GetComponent<Rigidbody>().transform.position.y <= 0.6250001f) {
				Vector3 jump = new Vector3 (0.0f, 200.0f, 0.0f);

				GetComponent<Rigidbody>().AddForce (jump);
			}
		}

	}


}
