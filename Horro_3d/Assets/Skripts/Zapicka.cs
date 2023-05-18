using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Zapicka : MonoBehaviour
{

    private int coins = 0;
    public Text coinsText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin" )
        {
            coins++;
            other.gameObject.SetActive(false);
            coinsText.text = coins.ToString();
        }
    
    }

    void Update()
    {
        Win();
    }
    
    
    void Win()
    {
        if(coins == 10)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(3);
        }
    }



}
