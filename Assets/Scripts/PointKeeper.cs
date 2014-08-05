using UnityEngine;
using System.Collections;

public class PointKeeper : MonoBehaviour {
	TextMesh textMesh;
	int score;

	public void Increment () {
		score = int.Parse(textMesh.text);
		score++;
		textMesh.text = score.ToString();
	}

	// Use this for initialization
	void Start () {
		textMesh = this.GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
