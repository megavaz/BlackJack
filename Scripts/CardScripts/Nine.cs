using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nine : MonoBehaviour {

    public static int value = 9;
    private void OnEnable()
    {
        if (DealerScript.whotogive == 1)
            DealerScript.PlayerScore += 9;
        if (DealerScript.whotogive == 2)
            DealerScript.DealerScore += 9;
        DealerScript.valuebuf = value;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
