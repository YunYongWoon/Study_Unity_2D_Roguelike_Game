using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour{
	public static GameManager instance = null;
	public BoardManager boardScropt;
	public int playerFoodPoints = 100;
	[HideInInspector] public bool playersTurn = true;

	private int level = 3;

	// Start is called before the first frame update
    void Awake() {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);
		boardScropt = GetComponent<BoardManager>();
		InitGame();
    }

	void InitGame () {
		boardScropt.SetupScene(level);
	}

	public void GameOver () {
		enabled = false;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
