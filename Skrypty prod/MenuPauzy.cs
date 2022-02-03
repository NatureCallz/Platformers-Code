using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPauzy : MonoBehaviour {

    public static bool GraJestZapauzowana = false;
    public GameObject menuPauzy;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GraJestZapauzowana)
            {
                Powrót();
            }else
            {
                Pauza();
            }
        }
	}

    public void Powrót()
    {
        menuPauzy.SetActive(false);
        Time.timeScale = 1f;
        GraJestZapauzowana = false;
    }

    void Pauza ()
    {
        menuPauzy.SetActive(true);
        Time.timeScale = 0f;
        GraJestZapauzowana = true;
    }

    public void ŁadowanieMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void WyjścieZGry()
    {
        Debug.Log("Wychodzenie z gry...");
        Application.Quit();
    }
}

