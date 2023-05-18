using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void Nextlevel(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }    

    public void Ext()
    {
        Application.Quit();
    }


}
