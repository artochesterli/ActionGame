using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnstablePlatform : MonoBehaviour {

    
    private float time_lived;
    private bool generate;
    public float lifetime;
    public int index;
    public bool pressed;
	// Use this for initialization
	void Start () {
        time_lived = 0;
        generate = false;
        pressed = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!generate && pressed)
        {
            generate = true;
            if (index >= 0)
            {
                for (int i = 0; i < Controller.appearing_platform[index].generate_list.Count; i++)
                {
                    GameObject g = (GameObject)Instantiate(Resources.Load("Prefabs/UnstablePlatform"), Controller.appearing_platform[Controller.appearing_platform[index].generate_list[i]].pos, new Quaternion(0, 0, 0, 0));
                    g.GetComponent<UnstablePlatform>().index = Controller.appearing_platform[index].generate_list[i];
                    if(g.GetComponent<UnstablePlatform>().index==1|| g.GetComponent<UnstablePlatform>().index == 2 || g.GetComponent<UnstablePlatform>().index == 3 || g.GetComponent<UnstablePlatform>().index == 4)
                    {
                        g.GetComponent<UnstablePlatform>().lifetime = 4;
                    }
                    else if(g.GetComponent<UnstablePlatform>().index == 0)
                    {
                        g.GetComponent<UnstablePlatform>().lifetime = 2f;
                    }
                    else
                    {
                        g.GetComponent<UnstablePlatform>().lifetime = 9;
                    }
                    g.transform.localScale = new Vector3(4, 0.5f, 4);
                }
            }
        }
        time_lived += Time.deltaTime;
        GetComponent<Renderer>().material.color = new Color(1, 1 - time_lived / lifetime, 1 - time_lived / lifetime);
        if (time_lived > lifetime)
        {
            for(int i=0;i< Controller.PressPlatform_list.Count; i++)
            {
                Controller.PressPlatform_list[i].GetComponent<PressPlatform>().pressed = false;
                Controller.PressPlatform_list[i].GetComponent<PressPlatform>().time = 0;
            }
            Controller.current_index_list.Clear();
            Controller.generated = false;
            Controller.ok = false;
            if (index == 9)
            {
                GameObject.Find("GodPlatform").GetComponent<GodPlatform>().pressed = false;
                GameObject.Find("GodPlatform").GetComponent<GodPlatform>().trigger = false;
            }
            Destroy(this.gameObject);
        }
	}
}
