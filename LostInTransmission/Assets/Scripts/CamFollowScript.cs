using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowScript : MonoBehaviour {

	// Store a refrence of the ship's game object
	public GameObject theCharacter;

	// store a speed at which we want to follow the ship
	public float followSpeed;


	// Fixed update is called automatically by MonoBehaviour
	void FixedUpdate () {

		// store the distance on every fixed update frame between the camera parent / transform and the ship's transform position.
		float superDistance = Vector2.Distance (transform.position, theCharacter.transform.position);

		// Assign a new vector 3 to the transform's position that is calculated by the lerp function. 
		// The lerp function takes 3 arguments a: where are we learping from. b: where are we learping to. c: where on the scale between the 2 we want to be
		transform.position = Vector3.Lerp (transform.position, theCharacter.transform.position,followSpeed* superDistance * Time.deltaTime);
	}
}
