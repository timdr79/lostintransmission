using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;


// We are using this class to control the wave.
public class WaveControl : MonoBehaviour {

	private bool boost;
	public float doublespeed;

	// here we store a refrence to the rigidbody. x
	public Rigidbody waveRigid;

	// Here we store the speed that we would like to add to move the wave. 
	public float speed;

	// Here we store rather or not the space bar is pushed down. 
	private bool boosterOn = false;

	// here we will store a ref to the game object that represents the mouse position
	//public Transform mouseLocVisual;

	// this allows us to set how fast we want the wave to spin. 
	public float rotationSpeed = 10;

	// store 2 variables for the particle systems that are our after burnners
	//public ParticleSystem afterBurn_right,afterBurn_left;


	// Here we store the sliders of UI so we can manipulate them in the game. 
	public Slider healthBar , energyBar;

	// This allows us to set the max health from the editor. 
	public float MaxHealth;

	// this is the health we manipulate from code
	float health;

	// this is where we keep track of energy
	float energy = 0;

	// this is the rate of how much energy should charge per second. 
	public float chargeRate = 1f;

	// we store the last collider so that we do not collide with it again. 
	Collider2D lastHit;

	// the audio source is what plays our audio 
	public AudioSource audioPlayer;

	// the audio clip is which audio we play
	public AudioClip explosionSound, repulseSound;

	//repel force strength
	public float repelForce;


	private PlayerController sliderControl;



	void Start(){
		// in start we set the health to the max health. 
		health = MaxHealth;
		waveRigid.freezeRotation = true;
		GameObject slider = GameObject.Find ("Slider");
		sliderControl = slider.GetComponent<PlayerController> ();


	}
	void update(){
		if(Input.GetKeyDown(KeyCode.Space)){
			waveRigid.AddForce(transform.forward*speed*doublespeed);
		}
	}



	// update happens on every frame. 
//	void Update(){
//		// if the enrgy is less than 1, increate energy by charge rate.
//		if (energy< 1) {
//			energy += Time.deltaTime * chargeRate;
//		}

		// update the enrgy ui by the energy value.
//		energyBar.value = energy;

		// store a variable for the mouse position
//		Vector3 mousePos;
//		mousePos = Input.mousePosition;
//
//		// convert that position from screen space to world space
//		mousePos = Camera.main.ScreenToWorldPoint (mousePos);
//
//		// manually set the Z to 0 because otherwise it will be the z value of the camer position
//		mousePos.z = 0;
//
//		// apply the calculated position to the visual component
//		//mouseLocVisual.position = mousePos;
//
//		// store a variable for the direction we would like the wave to face
//		Vector3 wantedDirection;
//		wantedDirection = mousePos - transform.position;
//
//		// apply that direction over time
//		transform.right = Vector3.Lerp (transform.right, wantedDirection, rotationSpeed * Time.deltaTime);
//
//		// Assign the space bar value (true or false / down or up) to the bool
//		boosterOn = Input.GetKey (KeyCode.Space);

		// if the boosters are on. emit particles. 
//		if (boosterOn) {
//			afterBurn_left.Emit (2);
//			afterBurn_right.Emit (2);
//		}

		// if we hit the right mouse button trigger the energy pulse
//		if (Input.GetMouseButtonDown (1)) {
//			EnergyPulse ();
//		}

//	}

	void EnergyPulse(){
//		//  If energy pulse is too low, stop the function
//		if (energy < 0.5f)
//			return;
//
//		// play the energy pulse sound. 
//
//		// if energy is more than 90%, destory all astroids in range. 
//		if (energy > 0.9f) {
//			// DESTROY ALL ASTROIDS IN RADIUS
//			Collider2D[] astrtoidsInRange = Physics2D.OverlapCircleAll(transform.position,20);
//			Debug.Log (astrtoidsInRange.Length);
//			audioPlayer.PlayOneShot (explosionSound);
//			for (int i = 0; i < astrtoidsInRange.Length; i++) {
//				if (astrtoidsInRange [i] != gameObject.GetComponent<Collider2D> ()) {
//					Destroy (astrtoidsInRange [i].gameObject);
//				}
//			}
//		}
//		// else energy is between 90% and 50%, push the astroids away. 
//		else {
//			// ADD FORCE TO ALL ASTROIDS IN RADIUS
//			Collider2D[] astrtoidsInRange = Physics2D.OverlapCircleAll(transform.position,20);
//			audioPlayer.PlayOneShot (repulseSound);
//			for (int i = 0; i < astrtoidsInRange.Length; i++) {
//				if (astrtoidsInRange [i] != gameObject.GetComponent<Collider2D> ()) {
//					Rigidbody2D aRigid;
//					aRigid = astrtoidsInRange [i].GetComponent<Rigidbody2D> ();
//					//find direction between each asteroid and wave position then multiply by a force and add an impuls
//					aRigid.AddForce (transform.position * repelForce);
//					Debug.Log ("repel asteroids");
//				}
//			}
//		}
//		// reset energy to 0 to force is to charge. 
//		energy = 0;
	}

//	// fixed update happens on every physics calculation
//	void FixedUpdate(){
//
//		// if the space bar is down, apply force to the wave's rigid relative to the wave's direction
////		if (boosterOn) {
////			waveRigid.AddForce (transform.right * speed);
////		}
//
//	}

	public void Move(float horizontal, float vertical, bool boost)
	{
		waveRigid.AddForce (transform.right * speed * horizontal);
		waveRigid.AddForce (transform.up * speed * vertical);

	}


		private void Update()
		{
			if (!boost)
			{
				// Read the jump input in Update so button presses aren't missed.
				boost = CrossPlatformInputManager.GetButtonDown("Jump");
			}
		}


		private void FixedUpdate()
		{
			// Read the inputs.
			float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
			float vertical = CrossPlatformInputManager.GetAxis ("Vertical");
			// Pass all parameters to the character control script.
			Move(horizontal, vertical, boost);
			boost = false;
		}

	// if we collide with an object and its not the same as the last object we collided with, take damage and update the health bar. 
	void OnCollisionEnter2D(Collision2D col){
//		if (lastHit == col.collider) {
//			return;
//		}
//
//		lastHit = col.collider;
//
//		health -= 5;
//		//Debug.Log(health);
//		healthBar.value =  health / MaxHealth;
//		if (health <= 0) {
//			//destory wave
//		}
	}

	void healthIncrease(){
		sliderControl.health *= 1.1f;
		if (sliderControl.health > 1f) {
			sliderControl.health = 1f;
		}
		sliderControl.healthBar.value = sliderControl.health;
	}

	void healthDecrease(){
		sliderControl.health *= 0.9f;
		if (sliderControl.health < 0f) {
			sliderControl.health = 0f;
		}
		sliderControl.healthBar.value = sliderControl.health;
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 8) {
			Debug.Log ("Object entered the trigger");
			healthIncrease ();
			other.gameObject.SetActive (false);

		}


	}

	void OnTriggerStay(Collider other) 
	{
		if (other.gameObject.layer == 8) {
			Debug.Log ("Object stays in trigger");


		}

	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.layer == 8) {
			Debug.Log ("Object leaves trigger");

		}

	}


}
