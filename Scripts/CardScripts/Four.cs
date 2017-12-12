using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Four : MonoBehaviour {

    public static int value = 4;
    private void OnEnable()
    {
        if (DealerScript.whotogive == 1)
            DealerScript.PlayerScore += 4;
        if (DealerScript.whotogive == 2)
            DealerScript.DealerScore += 4;
        DealerScript.valuebuf = value;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
