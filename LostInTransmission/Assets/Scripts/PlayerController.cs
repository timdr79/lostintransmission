using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public Slider healthBar;
	public float health;
	public float dropRate;

	void Start() {

		//health = 1.0f;
		//dropRate = -0.02f;

	}

	void Update () {

		// Health gradually decreases over time of game
		health += Time.deltaTime * dropRate;

		healthBar.value = health;
		if (Input.GetKeyDown(KeyCode.Space)) {

			health -= Time.deltaTime * 1.0f;
			healthBar.value = health;
	
		}
	}

// if we collide with an object and its not the same as the last object we collided with, take damage and update the health bar. 
	void OnTriggerEnter2D(Collider2D other) {

		health -= 5;
	
		healthBar.value =  health;
		if (health <= 0) {
		//	Debug.LogError ("Stop");
		}
	}
}
