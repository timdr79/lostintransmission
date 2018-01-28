using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public Slider healthBar;
	public float health;
	public float dropRate;
	public Text lowHealthText;

	void Start() {

		//health = 1.0f;
		//dropRate = -0.02f;

	}

	void Update () {

		// Health gradually decreases over time of game
		health += Time.deltaTime * dropRate;
		healthBar.value = health;
		if (health <= 0.2) {
			lowHealthText.enabled = true;
		}
		if (health <= 0) {
			SceneManager.LoadScene("Defeat Scene");
		}
	}

// if we collide with an object and its not the same as the last object we collided with, take damage and update the health bar. 
	void OnTriggerEnter(Collider other) {

		//print("Triggered!");
		health -= 0.1f;
	
		healthBar.value =  health;

		if (other.gameObject.tag == "cat") {

			other.transform.GetChild(1).gameObject.SetActive(true);
			other.transform.GetChild(0).gameObject.SetActive(false);

		}
	}
}