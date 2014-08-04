using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	public int ball_speed;
	public GameObject ball_prefab;
	private int playerScore = new int();
	private int CPUScore = new int();

	public void BallSpawn () {
		float random = Random.Range(0,4);
		Vector2 speed = new Vector2();
		GameObject ball = (GameObject)Instantiate(ball_prefab);

		if(random < 1) {
			speed.x = ball_speed;
			speed.y = ball_speed;
		} else if (random < 2) {
			speed.x = ball_speed;
			speed.y = -ball_speed;
		} else if (random < 3) {
			speed.x = -ball_speed;
			speed.y = -ball_speed;
		} else if (random < 4) {
			speed.x = -ball_speed;
			speed.y = ball_speed;
		}

		ball.rigidbody2D.AddForce(speed);
	}

	public void PointScore(string player) {
		
	}

	// Use this for initialization
	void Start () {
		BallSpawn();
	}
}
