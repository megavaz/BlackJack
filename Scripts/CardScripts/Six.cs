using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Six : MonoBehaviour {

    public static int value = 6;

    private void OnEnable()
    {
        if (DealerScript.whotogive == 1)
            DealerScript.PlayerScore += 6;
        if (DealerScript.whotogive == 2)
            DealerScript.DealerScore += 6;
        if (DealerScript.whotogive == 3)
            DealerScript.SplitScore += 6;
        DealerScript.valuebuf = value;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
