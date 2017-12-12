using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Five : MonoBehaviour {

    public static int value = 5;
    private void OnEnable()
    {
        if (DealerScript.whotogive == 1)
            DealerScript.PlayerScore += 5;
        if (DealerScript.whotogive == 2)
            DealerScript.DealerScore += 5;
        DealerScript.valuebuf = value;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
