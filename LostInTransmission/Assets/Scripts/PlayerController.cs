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
		/*if (Input.GetKeyDown(KeyCode.Space)) {

			health -= Time.deltaTime * 1.0f;
			healthBar.value = health;
	
		}*/
	}

// if we collide with an object and its not the same as the last object we collided with, take damage and update the health bar. 
	void OnTriggerEnter(Collider other) {

		//print("Triggered!");
		health -= 0.1f;
	
		healthBar.value =  health;

		other.gameObject.GetComponent<AudioSource>().Play();

		if (other.gameObject.tag == "cat") {

			other.transform.GetChild(1).gameObject.SetActive(true);
			other.transform.GetChild(0).gameObject.SetActive(false);

		}

		if (health <= 0) {
		//	Debug.LogError ("Stop");
		}
	}
}
