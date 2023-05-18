using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousControl : MonoBehaviour
{
    private float mouseX;
    private float mouseY;
    
    public float Sensa = 200f; 
    public Transform Player;
    
     // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;        
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * Sensa * Time.deltaTime;        
        mouseY = Input.GetAxis("Mouse Y") * Sensa * Time.deltaTime;
    
        Player.Rotate(mouseX * new Vector3(0, 1, 0));

        transform.Rotate(-mouseY * new Vector3(1, 0, 0));
   
    }
}