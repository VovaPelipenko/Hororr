using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject Menu;
    [SerializeField] KeyCode PauseMenu;
    bool isMenu = false;

    
    void Start()
    {
        Menu.SetActive(false);
    }

    void Update()
    {
        Active();
    }
    
    
    void Active()
    {
        if(Input.GetKeyDown(PauseMenu))
        {
            isMenu = !isMenu;
        }
    
        if (isMenu)
        {
            Menu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        else
        {
            Menu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
        }
    }


    public void Comtinoe()
    {
        isMenu = false;
    }






}
