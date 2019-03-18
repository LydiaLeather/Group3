using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    //private void OnGUI()
    //{
    //if(GUI.Button(new Rect(Screen.width/2.5f,Screen.height/3,Screen.width/5,Screen.height/10), "Load Game"))
    // {
   // Application.LoadLevel(1);
        //}
        //if (GUI.Button(new Rect(Screen.width / 2.5f, Screen.height / 2, Screen.width / 5, Screen.height / 10), "Exit Game"))
        //{
            //Application.Quit();
        //}

        //}
    //}
     void start()
    {

    }
    void Update()
    {

    }
    public void StartGame()
    {
        Application.LoadLevel(0);
    }
    public void Ouit()
    {
        Application.Quit();
    }
}