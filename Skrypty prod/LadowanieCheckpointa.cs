using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadowanieCheckpointa : MonoBehaviour
{

    public LevelManager levelManager;

    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();

    }


    // Update is called once per frame
    void Update()
    {

    


   
    
        if (Input.GetKeyDown(KeyCode.L))
        {
           
           levelManager.RespawnPlayer();

       
                   
                        levelManager.ZmianaEnergii(-1);



                    }
    }
}
