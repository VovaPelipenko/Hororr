using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spes : MonoBehaviour
{
    public int damage;
    private AudioSource A;

    // Start is called before the first frame update
    void Start()
    {
        A = GetComponent<AudioSource> ();  
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            col.GetComponent<Healf>().healf -= damage;
            A.Play();
        }
    }

}
