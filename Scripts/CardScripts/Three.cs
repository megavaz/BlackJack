using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Three : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnEnable()
    {
        if (DealerScript.whotogive == 1)
            DealerScript.PlayerScore += 3;
        if (DealerScript.whotogive == 2)
            DealerScript.DealerScore += 3;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
