using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class details : MonoBehaviour
{

    public static float Dets = 0;
    public Text coinsText;

    void Start()
    {
        Dets = 0;
    }
    
    
    
    
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "D")
        {
            Dets++;
            coinsText.text = Dets.ToString();
            Destroy(coll.gameObject);
        }
    }
}
