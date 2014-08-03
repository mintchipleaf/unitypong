using UnityEngine;
using System.Collections;

public class PaddleMove : MonoBehaviour {

	public Vector2 speed = new Vector2(0,10);
	
	private Vector2 movement;
	
	void Update () {
		float inputX = 0;
		float inputY = 0;
		
		if (Input.GetKey ("up")){
			inputY = 1;
		}
		if (Input.GetKey ("down")){
			inputY = -1;
		}
		
		
		movement = new Vector2(
			speed.x * inputX,
			speed.y * inputY);
	}
	void FixedUpdate () {
		rigidbody2D.velocity = movement;
		//rigidbody2D.AddForce(Vector2.up);
	}

}
