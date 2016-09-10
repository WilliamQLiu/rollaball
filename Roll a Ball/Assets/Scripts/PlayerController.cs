using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed; // public makes this variable appear in editor

	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

//	void Update () // Update is called before rendering a frame (most of our game code)
//	{
//		
//	}

	void FixedUpdate () // FixedUpdate is called before applying any Physics Updates
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
	}
}