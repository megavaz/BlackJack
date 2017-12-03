using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Two : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnEnable()
    {
        DealerScript.buf += 2;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
