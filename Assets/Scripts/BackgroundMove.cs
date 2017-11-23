using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour {
	public float speed = 0.05f;

	public float size = 20.48f;

	void Update()
	{
		Vector2 position = this.transform.position;
		position += Vector2.left * speed;

		if (position.x <= -size) {
			position.x += size * 2.0f;
			GetComponentInChildren<Obstacle> ().RandomPosition ();
		}

		transform.position = position;

	}
}
