using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("Level loaded: "+name);
		Brick.brickCount = 0;
		SceneManager.LoadScene(name);
	}

	public void QuitRequest() {
		Debug.Log("Goodbye!");
		Application.Quit();
	}

	public void LoadNextLevel ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
