using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour {

	public Vector2 speed = new Vector2(15,15);

	private float random = Random.Range(0,1);

	public void Spawn () {
		transform.position = new Vector3(0, 0, 0);
		this.rigidbody2D.AddForce(speed);

	}

	// Use this for initialization
	void Start () {
		Spawn();
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.collider2D.
	}
}
