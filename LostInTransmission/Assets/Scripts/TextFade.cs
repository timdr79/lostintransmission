using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFade : MonoBehaviour {

	private Text text;
	private float a;
	private bool fadeIn;

	// Use this for initialization
	void Start () {
		text = this.GetComponent<Text> ();
		a = 50.0f;
		fadeIn = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (a >= 50.0f) {
			fadeIn = false;
		} else if (a <= 0.0f) {
			fadeIn = true;
		}

		if (fadeIn) {
			a += 1f;
			text.CrossFadeAlpha (1, 1, false);
		} else {
			a -= 1f;
			text.CrossFadeAlpha (0, 1, false);
		}
	}
}
