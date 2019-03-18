using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class combiningscenes : MonoBehaviour
{

    public void SceneSwitcher()
    {
        SceneManager.LoadScene(1);
    }

    public void SceneSwitcher2()
    {
        Application.LoadLevel(2);
    }

}

