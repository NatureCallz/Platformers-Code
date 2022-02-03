using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cos : MonoBehaviour {

    public float moveSpeed;
    private Rigidbody2D przeciwnik;
    public Transform point1;
    public Transform point2;
    public bool left;
    public LevelManager levelManager;
    public RuchGracza gracz;

	// Use this for initialization
	void Start () {

        przeciwnik = GetComponent<Rigidbody2D>();
        left = true;
        levelManager = FindObjectOfType<LevelManager>();
        gracz = FindObjectOfType<RuchGracza>();
	}
	
	// Update is called once per frame
	void Update () {

        if(przeciwnik.position.x < point1.position.x) {
            left = false;
         }
        if(przeciwnik.position.x > point2.position.x) {
            left = true;
         }

        if(left) {

            przeciwnik.velocity = new Vector2(-moveSpeed, przeciwnik.velocity.y);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else {

            przeciwnik.velocity = new Vector2(moveSpeed, przeciwnik.velocity.y);
            transform.localScale = new Vector3(-1f, 1f, 1f);

        }

        
	}
    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.name == "Gracz") {
            levelManager.ZmianaEnergii(-1);
          
            
      
        }
    }
}
