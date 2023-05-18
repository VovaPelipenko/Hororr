using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aodi : MonoBehaviour
{
    public bool ison;

    private void Start()
    {
        ison = true;
    }

    public void OnOffSound()
    {
        AudioListener.volume = 1f;
        if(!ison)
        {
            AudioListener.volume = 1f;
            ison = true;
        }
        else if (ison)
        {
            AudioListener.volume = 0f;
            ison = false;
        }
    
    }
}
