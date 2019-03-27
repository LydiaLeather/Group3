using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructionsScript : MonoBehaviour
{
    private string camInst = " ";
    private bool show=false;

    // Start is called before the first frame update
    void Start()
    {
        camInst = " ";
        camInst += "- FOR PLAYER 1 ";
        camInst += "- use UP ARROW to JUMP \n";
        camInst += "- use RIGHT ARROW to MOVE RIGHT \n";
        camInst += "- use LEFT ARROW to MOVE LEFT \n";
        camInst += "- use DOWN ARROW to SLIDE DOWN \n";
        camInst += "- press L for FIRE ATTACK \n";

        camInst += "- FOR PLAYER 2 ";
        camInst += "- press T to JUMP \n";
        camInst += "- press H to MOVE RIGHT \n";
        camInst += "- press F to MOVE LEFT \n";
        camInst += "- press G to SLIDE DOWN \n";
        camInst += "- press Y for FIRE ATTACK \n";


    }

    // Update is called once per frame
    void Update()
    {
    }
        void OnGUI()
        {
            if(GUI.Button(new Rect(Screen.width-40,5,35,35), " ! "))
            {
                show = !show;
            }
            if (show) GUI.Label(new Rect(Screen.width-310, 35, 300, 500), camInst);
        }
    }

