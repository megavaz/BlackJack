﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ten : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnEnable()
    {
        if (DealerScript.whotogive == 1)
            DealerScript.PlayerScore += 10;
        if (DealerScript.whotogive == 2)
            DealerScript.DealerScore += 10;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
