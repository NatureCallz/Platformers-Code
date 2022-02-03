using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kluczyk : MonoBehaviour
{

    
    public string loadLevel;
    public SpriteRenderer kluczyk;
  


    // Use this for initialization
    void Start()
    {

        
        

    }

    private void Update()
    {
        
        {

           
        }

    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.name == "Gracz")
        {
            SceneManager.LoadScene(2);


        }
    }
}
