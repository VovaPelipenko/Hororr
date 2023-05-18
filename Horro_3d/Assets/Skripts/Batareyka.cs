using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batareyka : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            if (Input.GetKeyDown (KeyCode.E))
            {
                col.gameObject.GetComponent<Fonarik> ().Energy += 25;
                Destroy (gameObject);
            }
        }
    }

}
