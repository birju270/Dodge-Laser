using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutton : MonoBehaviour
{


    void Start()
    {

    }

    public void OpenScene()
    {
        
        SceneManager.LoadScene("MainMenu");
    }

}