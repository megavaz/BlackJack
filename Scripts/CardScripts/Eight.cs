﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Eight : MonoBehaviour {

    public static int value = 8;
    
    private void OnEnable()
    {
        if (DealerScript.whotogive == 1)
            DealerScript.PlayerScore += 8;
        if (DealerScript.whotogive == 2)
            DealerScript.DealerScore += 8;
        if (DealerScript.whotogive == 3)
            DealerScript.SplitScore += 8;
        DealerScript.valuebuf = value;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
