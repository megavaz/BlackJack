using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerScript : MonoBehaviour {
    public Text countText;
    public static int count;
    


    // Use this for initialization
    void Start ()
    {
        count = 0;
        countText.text = "Player Count: " + count.ToString();        
    }
	
	// Update is called once per frame
	void Update () {
        countText.text = "Player Count: " + count.ToString();      


    }
}
