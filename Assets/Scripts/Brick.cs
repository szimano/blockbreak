using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
	public Sprite[] hitSprites;

	private int timesHit;

	private LevelManager levelManager;

	public static int brickCount = 0;

	// Use this for initialization
	void Start () {
		timesHit = 0;
		brickCount++;
		levelManager = GameObject.FindObjectOfType<LevelManager>();	
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnCollisionEnter2D(Collision2D collision) {
		timesHit++;
		int maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits) {
			Destroy(gameObject);
			brickCount--;
			if (brickCount <= 0) {
				levelManager.LoadNextLevel();
			}
		} else {
			LoadSprites();
		}
	}

	void LoadSprites() {
		int spriteIndex = timesHit - 1;
		this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
	}
}
