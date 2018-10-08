using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePlatform : MonoBehaviour {

    public bool pressed;
    public int index;
    // Use this for initialization
    void Start () {
        pressed = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (pressed)
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
}
