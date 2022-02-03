using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LicznikMonet : MonoBehaviour {

    public LevelManager levelManager;
    public Text licznikMonet;

	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<LevelManager>();
        licznikMonet = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
        licznikMonet.text = "" + levelManager.IleJeszczeMonet;
	}
}
