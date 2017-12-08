using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seven1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnEnable()
    {
        if (DealerScript.whotogive == 1)
            DealerScript.PlayerScore += 7;
        if (DealerScript.whotogive == 2)
            DealerScript.DealerScore += 7;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
