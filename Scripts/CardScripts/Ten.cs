using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ten : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnEnable()
    {
        DealerScript.buf += 10;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
