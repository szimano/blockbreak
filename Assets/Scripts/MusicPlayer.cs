using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	static Object _gameObj;
	// Use this for initialization

	void Awake() {
		if (_gameObj == null) {
			_gameObj = gameObject;	
			GameObject.DontDestroyOnLoad(gameObject);	
		} else {
			GameObject.Destroy(gameObject);	
		}
	}

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
