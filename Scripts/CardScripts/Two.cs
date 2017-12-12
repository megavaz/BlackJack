using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two : MonoBehaviour {

    public static int value = 2;

    private void OnEnable()
    {
        if (DealerScript.whotogive == 1)
            DealerScript.PlayerScore += 2;
        if (DealerScript.whotogive == 2)
            DealerScript.DealerScore += 2;
        DealerScript.valuebuf = value;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
