using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seven1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnEnable()
    {
        DealerScript.buf += 7;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
