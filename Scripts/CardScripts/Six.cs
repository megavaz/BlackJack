using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Six : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnEnable()
    {
        DealerScript.buf += 6;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
