﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public bool autoPlay = false;

	private Ball ball;

	void Start() {
		ball = GameObject.FindObjectOfType<Ball>();
	}

	// Update is called once per frame
	void Update () {
		if (!autoPlay) {
			MoveWithMouse();
		} else {
			AutoPlay();
		}
	}

	void MoveWithMouse() {
		float mousePosInBlocks = (Input.mousePosition.x / Screen.width * 16);
		this.transform.position = new Vector3(Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f), this.transform.position.y, this.transform.position.z);
	}

	void AutoPlay() {
		float ballPosition = ball.transform.position.x;
		this.transform.position = new Vector3(Mathf.Clamp(ballPosition, 0.5f, 15.5f), this.transform.position.y, this.transform.position.z);	
	}
}
