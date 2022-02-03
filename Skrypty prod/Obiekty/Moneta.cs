using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneta : MonoBehaviour {
    public LevelManager levelManager;

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();

    }

    void OnTriggerEnter2D(Collider2D collision) {

        if (collision.name == "Gracz") {

            levelManager.IleJeszczeMonet -= 1;
            Destroy(gameObject);
        }
     }
}
