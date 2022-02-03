using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Menu : MonoBehaviour {

    public Canvas quitMenu;
    public Button buttonStart;
    public Button buttonExit;

    private Canvas menuUI;



	// Use this for initialization
	void Start () {

        menuUI = (Canvas)GetComponent<Canvas>();

        quitMenu = quitMenu.GetComponent<Canvas>();

        buttonStart = buttonStart.GetComponent<Button>();
        buttonExit = buttonExit.GetComponent<Button>();

        quitMenu.enabled = false;

        Time.timeScale = 0;
        Cursor.visible = menuUI.enabled;
        Cursor.lockState = CursorLockMode.Confined;

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Escape)) {
            menuUI.enabled = !menuUI.enabled;

            Cursor.visible = menuUI.enabled;

            if (menuUI.enabled)
            {
                Cursor.lockState = CursorLockMode.Confined;
                Time.timeScale = 0;

            }
            else {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                Time.timeScale = 1;

            }

        }
		
	}

    public void PrzyciskWyjscie() {
        quitMenu.enabled = true;
        buttonStart.enabled = true;
        buttonExit.enabled = true;
    }

    public void PrzyciskStart () {
        menuUI.enabled = false;

        Time.timeScale = 1;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        buttonStart.enabled = true;
    }
    public void PrzyciskTakWyjdz () {
        Application.Quit();
    }
}
