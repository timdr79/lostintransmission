using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour {

	private GameObject wave;
	private bool isFollowing = false;

	//Order in which the note follows
	public int followIndex;

	// store a speed at which we want to follow the ship
	public float followSpeed;


	// Fixed update is called automatically by MonoBehaviour
	void FixedUpdate () {

		if (isFollowing) {
			// store the distance on every fixed update frame between the camera parent / transform and the ship's transform position.
			float superDistance = Vector2.Distance (transform.position, wave.transform.position);

			Vector3 positionLocation = new Vector3 (wave.transform.position.x, wave.transform.position.y - (followIndex + 2), 0);

			// Assign a new vector 3 to the transform's position that is calculated by the lerp function. 
			// The lerp function takes 3 arguments a: where are we learping from. b: where are we learping to. c: where on the scale between the 2 we want to be
			transform.position = Vector3.Lerp (transform.position, positionLocation, (followSpeed/followIndex) * superDistance * Time.deltaTime);
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "thisisaship") {
			FollowWave(other);
			ScaleDown ();
		}
	}

	void FollowWave(Collider other)
	{
		wave = other.gameObject;
		//Disable collider
		SphereCollider collider = GetComponent<SphereCollider> ();
		collider.enabled = false;
		isFollowing = true;
	}

	void ScaleDown()
	{
		float newScale = transform.localScale.x / 3;
		transform.localScale = new Vector3 (newScale, newScale, newScale);
	}

	void OnTriggerStay(Collider other) 
	{
//		Debug.Log ("Object in the trigger");

	}

	void OnTriggerExit(Collider sother)
	{
//		Debug.Log ("Object exited the trigger");
	
	}

}
