using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Healf : MonoBehaviour
{
    public int healf;
    public Slider slider;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = healf;
        Degef();
    }

    void Degef()
    {
        if (healf <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(2);
        } 
        
        
    }
 

}
