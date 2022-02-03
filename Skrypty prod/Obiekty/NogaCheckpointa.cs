using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NogaCheckpointa : MonoBehaviour
{

    //Zmiana flagi
    public Sprite flagaGora;
    public Sprite flagaDol;
    private SpriteRenderer nogaCheckpointaSpriteRenderer;
    public bool nogaCheckpointaReached;
    //Koniec zmiana flagi

    

    // Use this for initialization
    void Start()
    {
        

        //Zmiana flagi
        nogaCheckpointaSpriteRenderer = GetComponent<SpriteRenderer>();
        //Koniec zmiana flagi

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Gracz")
        {
            
         
            //Zmiana flagi
            nogaCheckpointaSpriteRenderer.sprite = flagaDol;
            nogaCheckpointaReached = true;
            //Koniec zmiana flagi
        }
        {
            if (other.name == "Gracz")
                this.gameObject.SetActive(false);
        }


    }
}

