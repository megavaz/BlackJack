using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Picture : MonoBehaviour
{

    public static int value = 10;
    private void OnEnable()
    {
        if (DealerScript.whotogive == 1)
            DealerScript.PlayerScore += 10;
        if (DealerScript.whotogive == 2)
            DealerScript.DealerScore += 10;
        DealerScript.valuebuf = value;
    }


    // Update is called once per frame
    void Update()
    {


    }
}
