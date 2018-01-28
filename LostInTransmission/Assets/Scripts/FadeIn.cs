using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeIn : MonoBehaviour {

	public bool fadeIn = false;
	float FadeTime =  1;

	void Update()
	{
	  if (fadeIn)
		{

	  if (GetComponent<AudioSource>().volume < 1)
			{
	  GetComponent<AudioSource>().volume += Time.deltaTime / FadeTime;
			}
	else if (GetComponent<AudioSource>().volume > 1)
			{
	   GetComponent<AudioSource>().volume = 1;
			}	

		}
	}
}
