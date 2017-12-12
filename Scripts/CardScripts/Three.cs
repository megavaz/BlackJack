using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three : MonoBehaviour {

    public static int value = 3;

    private void OnEnable()
    {
        if (DealerScript.whotogive == 1)
            DealerScript.PlayerScore += 3;
        if (DealerScript.whotogive == 2)
            DealerScript.DealerScore += 3;
        DealerScript.valuebuf = value;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
