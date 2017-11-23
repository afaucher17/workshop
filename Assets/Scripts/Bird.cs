using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
	public float speed = 400.0f;

	private bool _death = false;

	private Rigidbody2D _rg2d;
	private Animator _animator;

	// Use this for initialization
	void Start () {
		_rg2d = GetComponent<Rigidbody2D> ();
		_animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate () {
		// Input.GetKeyDown(KeyCode.Space)
		if (_death == false
			&& (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)))
		{
			// We get the component named Rigidbody2d
			_rg2d.velocity = Vector2.zero;
			_rg2d.AddForce(Vector2.up * speed);
			_animator.SetTrigger ("Flap");

			// Vector2.up == new Vector2(0, 1)
		}
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		_death = true;
		_animator.SetTrigger ("Death");
		GameManager.instance.DisplayGameOverText ();
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		GameManager.instance.ChangeScoreValue ();
	}
}
