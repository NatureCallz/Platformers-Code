using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Drzwi : MonoBehaviour {

    public LevelManager levelManager;
    public string loadLevel;
    public SpriteRenderer drzwi;
    public Sprite otwarteDrzwi;


	// Use this for initialization
	void Start () {

        levelManager = FindObjectOfType<LevelManager>();
        drzwi = GetComponent<SpriteRenderer>();

	}

    private void Update(){
        if (levelManager.drzwi) {

            drzwi.sprite = otwarteDrzwi;
        }
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D (Collider2D collider){
		if (collider.name == "Gracz" && levelManager.drzwi) {
            SceneManager.LoadScene(3);


        }
	}
}
