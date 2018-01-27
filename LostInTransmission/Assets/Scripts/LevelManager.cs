using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void StartGameBtn(string Main){
		SceneManager.LoadScene ("Main");
	}
	public void GameoverScreen(string GameOver){
		SceneManager.LoadScene ("GameOver");
	}
	public void VictoryScreen(string Victory){
		SceneManager.LoadScene ("Victory");
	}
	public void MainMenuBtn(string Start){
		SceneManager.LoadScene ("Start");
	}
}

