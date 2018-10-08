using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodPlatform : MonoBehaviour {

    public bool pressed;
    public bool trigger;
	// Use this for initialization
	void Start () {
        pressed = false;
        trigger = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!trigger && pressed)
        {
            trigger = true;
            GameObject g = (GameObject)Instantiate(Resources.Load("Prefabs/UnstablePlatform"), Controller.appearing_platform[0].pos, new Quaternion(0, 0, 0, 0));
            g.GetComponent<UnstablePlatform>().index = 0;
            g.GetComponent<UnstablePlatform>().lifetime = 2;
            g.transform.localScale = new Vector3(4, 0.5f, 4);
        }
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
