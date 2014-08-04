using UnityEngine;
using System.Collections;

public class PointScore : MonoBehaviour {

	public GameObject score_target;		//Score to increment
	private GameManager gameManager;	//GameManager component


	void OnTriggerEnter2D(Collider2D other) {

//		target.guiText.text = ToString(int.Parse(target.guiText.text) + 1);

		Destroy(other.gameObject);	//Removes whatever collides with it
		gameManager.BallSpawn();	//Calls BallSpawn function of component

	}

	// Use this for initialization
	void Start () {
		gameManager = Camera.main.GetComponent<GameManager>();	//Stores GameManager compnent on Camera as gameManager
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
