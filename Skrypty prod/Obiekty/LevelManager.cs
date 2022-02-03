using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    private RuchGracza player;
    public GameObject curCheckpoint;

    float x;
    float y;
    float dx;
    float dy;

    public float energia;
    public GameObject Serce1;
    public GameObject Serce2;
    public GameObject Serce3;


    // Monety jesli beda dzialac
    public float IleJeszczeMonet;
    //Koniec monet

    //Drzwi
    public bool drzwi;
    //Koniec Drzwi

    // Use this for initialization
    void Start() {

        dx = transform.position.x - Camera.main.gameObject.transform.position.x;
        dy = transform.position.y - Camera.main.gameObject.transform.position.y;

        Serce1 = GameObject.Find("Serce1");
        Serce2 = GameObject.Find("Serce2");
        Serce3 = GameObject.Find("Serce3");
        

        //Drzwi
        drzwi = false;
        //Koniec Drzwi

        player = FindObjectOfType<RuchGracza>();
    }

    //Drzwi i Monety
    public void Monety() {
        if (IleJeszczeMonet == 0) {
            drzwi = true;
        }
        
    }
    //Koniec Drzwi i Monety

    // Update is called once per frame
    void Update() {
        //Sprawdzanie Monet
        Monety();
        //Koniec Sprawdzania Monet

        Pozycja();
        Energia();

    }

    void Pozycja() {

        x = Camera.main.gameObject.transform.position.x + dx;
        y = Camera.main.gameObject.transform.position.y + dy;
        transform.position = new Vector3(x, y, transform.position.z);

    }
    public void ZmianaEnergii(int wartosc) {
        energia = energia + wartosc;
    }


    public void RespawnPlayer() {
        Debug.Log("Player Respawn");
        player.transform.position = curCheckpoint.transform.position;

    }

    void Energia() {
        if (energia >= 3) {
            Serce3.GetComponent<Renderer>().enabled = true;
        }
        else {
            Serce3.GetComponent<Renderer>().enabled = false;
        }
        if (energia >= 2)
        {
            Serce2.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            Serce2.GetComponent<Renderer>().enabled = false;
        }
        if (energia >= 1)
        {
            Serce1.GetComponent<Renderer>().enabled = true;
        }
        else
        {
            Serce1.GetComponent<Renderer>().enabled = false;
        }
    }
}
