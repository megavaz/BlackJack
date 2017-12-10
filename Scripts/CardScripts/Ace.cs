using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Ace : MonoBehaviour {
    int status = 1;
    int whowasgivento = 0;
    
    private void OnEnable()
    {
        
        if (DealerScript.whotogive == 1)
            DealerScript.PlayerScore += 11;
        if (DealerScript.whotogive == 2)
            DealerScript.DealerScore += 11;
        whowasgivento = DealerScript.whotogive;
        status = 1;        
            
    }
    

    
    void Update () {

        if (DealerScript.whotogive == 1)
            if ((DealerScript.PlayerScore > 21) && (status == 1) && (whowasgivento == 1))
            {
                DealerScript.PlayerScore -= 10;
                status = 0;
            }

        if (DealerScript.whotogive == 2)
            if ((DealerScript.DealerScore > 21) && (status == 1) && (whowasgivento == 2))
            {
                DealerScript.DealerScore -= 10;
                status = 0;
            }
    }
}
