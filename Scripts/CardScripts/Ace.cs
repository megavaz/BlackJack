using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Ace : MonoBehaviour {
    int status = 1;
    
    void Start ()
    {

        
    }
    private void OnEnable()
    {
        
        DealerScript.buf += 11;
        status = 1;
        
            
    }
    

    
    void LateUpdate () {

        if ((DealerScript.buf > 21) && (status == 1))
        {
            DealerScript.buf -= 10;
            status = 0;
        }
            
    }
}
