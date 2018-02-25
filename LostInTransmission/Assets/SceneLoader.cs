using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

	[SerializeField]
	private int scene;


	// Use this for initialization
	void Start () {
		StartCoroutine (LoadNewScene());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator LoadNewScene() {

		yield return new WaitForSeconds (4);



		AsyncOperation async = SceneManager.LoadSceneAsync ("Main");



		while (!async.isDone) {
			yield return null;
		}
	}
}
