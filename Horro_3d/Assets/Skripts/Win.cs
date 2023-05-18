using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{   
    private void OnTriggerEnter(Collider coll)
    {
        if (details.Dets == 3)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(5);
        }
    }
}
