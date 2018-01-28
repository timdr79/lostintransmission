﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PlayerController : MonoBehaviour {

	public Slider healthBar;
	public float health;
	public float dropRate;
	public Text lowHealthText;

	public AudioMixerSnapshot Default;
	public AudioMixerSnapshot Win;

	public int winCount = 5;

	private int noteCount;

	public GameObject vfxPrefab;

	void Start() {

		//health = 1.0f;
		//dropRate = -0.02f;

	}

	void Update () {

		// Health gradually decreases over time of game
		if (healthBar != null) {
			health += Time.deltaTime * dropRate;
			healthBar.value = health;
			if (health <= 0.2) {
				lowHealthText.enabled = true;
			}
			if (health <= 0) {
				SceneManager.LoadScene("Defeat Scene");
			}
		}
	}

// if we collide with an object and its not the same as the last object we collided with, take damage and update the health bar. 
	void OnTriggerEnter(Collider other) {

		print("Triggered!");


		if (other.gameObject.tag == "cat") {

			health -= 0.1f;

			healthBar.value = health;

			if (other.transform.childCount > 1) {
				other.transform.GetChild (1).gameObject.SetActive (true);
				other.transform.GetChild (0).gameObject.SetActive (false);
			}
			PlaySound (other);


		} else if (other.gameObject.tag == "music") {
			HitMusicNote (other);
		} else if (other.gameObject.tag == "win") {
			CheckWinGame ();
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "cat") {
			//StopSound (other);
			//TODO: Maybe stop the angry father sound?
		}
	}

	void PlaySound(Collider other) {
		
		AudioSource audio = other.GetComponent<AudioSource> ();
		if (audio == null) {
			return;
		}
		audio.Play ();
	}

	void StopSound(Collider other) {
		AudioSource audio = other.GetComponent<AudioSource> ();
		if (audio == null) {
			return;
		}
		audio.Stop();
	}

	void HitMusicNote(Collider other) {
		HealthIncrease ();
		GatherNote (other);
	}

	void HealthIncrease(){
		health += .1f;
		if (health > 1f) {
			health = 1f;
		}
		healthBar.value = health;
	}

	void GatherNote(Collider other)
	{
		//other.gameObject.SetActive (false);
		noteCount++;
	}

	void HealthDecrease(){
		health *= 0.9f;
		if (health < 0f) {
			health = 0f;
		}
		healthBar.value = health;
	}

	void CheckWinGame()
	{
		if (noteCount >= winCount) {
			WinGame ();
		}
		//TODO: Maybe tell the user they havent won yet
	}

	void WinGame()
	{
		Win.TransitionTo (0.1f);
		transform.SetParent(null);
		DontDestroyOnLoad(gameObject);
		vfxPrefab.SetActive(true);
		StartCoroutine(WaitAndExplode(3.0f));
		//SceneManager.LoadScene("Victory Scene");
	}

	private IEnumerator WaitAndExplode(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndExplode " + Time.time);
			SceneManager.LoadScene("Victory Scene");
        }
    }
}