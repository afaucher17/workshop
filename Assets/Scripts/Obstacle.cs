using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	public float lowValue = -7.0f;
	public float highValue = -3.0f;

	// Use this for initialization
	void Start () {
		RandomPosition ();
	}

	public void RandomPosition()
	{
		Vector2 position = this.transform.position;
		position.y = Random.Range (lowValue, highValue);
		this.transform.position = position;
	}
}
