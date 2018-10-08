using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressPlatform : MonoBehaviour {

    public bool pressed;
    public int index;
    
    public float time;
    const float presstime=12f;
	// Use this for initialization
	void Start () {
        pressed = false;
        time = 0;
        Controller.PressPlatform_list[index] = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if (pressed)
        {
            GetComponent<Renderer>().material.color = Color.green;
            if (!Controller.ok)
            {
                time += Time.deltaTime;
                if (time >= presstime)
                {
                    for(int i = 0; i < Controller.PressPlatform_list.Count; i++)
                    {
                        Controller.PressPlatform_list[i].GetComponent<PressPlatform>().pressed = false;
                        Controller.PressPlatform_list[i].GetComponent<PressPlatform>().time = 0;
                    }
                    Controller.current_index_list.Clear();
                }
            }
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.yellow;
        }
	}
}
