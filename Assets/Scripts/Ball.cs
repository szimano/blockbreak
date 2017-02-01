using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private Paddle paddle;

	private Vector3 paddleToBall;

	private Rigidbody2D rb;

	private bool hasStarted = false;

	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<Paddle>();
		rb = GetComponent<Rigidbody2D>();
		paddleToBall = this.transform.position - paddle.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBall;	
		}

		if (Input.GetMouseButtonDown(0)) {
			rb.velocity = new Vector2(2f, 8f);
			hasStarted = true;
		}
	}
}
