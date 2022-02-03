using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    //Zmiana flagi
    public Sprite flagaGora;
    public Sprite flagaDol;
    private SpriteRenderer checkpointSpriteRenderer;
    public bool checkpointReached;
    //Koniec zmiana flagi

    public LevelManager levelManager;

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager> ();

        //Zmiana flagi
        checkpointSpriteRenderer = GetComponent<SpriteRenderer>();
        //Koniec zmiana flagi
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Gracz")
        {
            levelManager.curCheckpoint = gameObject;
            Debug.Log("Activated Check" + transform.position);
            //Zmiana flagi
            checkpointSpriteRenderer.sprite = flagaDol;
            checkpointReached = true;
            //Koniec zmiana flagi
        }
        {
            if (other.name == "Gracz")
                this.gameObject.SetActive (false);
}
    

    }
}
