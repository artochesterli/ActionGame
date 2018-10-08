using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public static List<int> right_index_list;
    public static List<int> current_index_list;
    public static List<GameObject> PressPlatform_list;
    public static bool ok;
    public static bool generated;
    public static List<JumpingPlatform> appearing_platform;
    // Use this for initialization
    private void Awake()
    {
        ok = false;
        current_index_list = new List<int>();
        right_index_list = new List<int>();
        PressPlatform_list = new List<GameObject>();
        for(int i = 0; i < 3; i++)
        {
            PressPlatform_list.Add(null);
        }
        right_index_list.Add(0);
        right_index_list.Add(1);
        right_index_list.Add(2);
        generated = false;
        appearing_platform = new List<JumpingPlatform>();
        List<int> generate_list = new List<int>();
        generate_list.Add(1);
        generate_list.Add(2);
        appearing_platform.Add(new JumpingPlatform(new Vector3(20, 15, -11), generate_list));
        generate_list.Clear();
        appearing_platform.Add(new JumpingPlatform(new Vector3(15, 15, -24), generate_list));
        generate_list.Clear();
        generate_list.Add(3);
        generate_list.Add(4);
        appearing_platform.Add(new JumpingPlatform(new Vector3(12, 15, -31), generate_list));
        generate_list.Clear();
        appearing_platform.Add(new JumpingPlatform(new Vector3(6, 15, -42), generate_list));
        generate_list.Clear();
        generate_list.Add(5);
        generate_list.Add(6);
        generate_list.Add(7);
        generate_list.Add(8);
        generate_list.Add(9);
        appearing_platform.Add(new JumpingPlatform(new Vector3(-1, 15, -46), generate_list));
        generate_list.Clear();
        
        appearing_platform.Add(new JumpingPlatform(new Vector3(-8, 15, -41), generate_list));
        generate_list.Clear();
        
        appearing_platform.Add(new JumpingPlatform(new Vector3(-8, 15, -28), generate_list));
        generate_list.Clear();
        
        appearing_platform.Add(new JumpingPlatform(new Vector3(-8, 15, -15), generate_list));
        generate_list.Clear();
        
        appearing_platform.Add(new JumpingPlatform(new Vector3(-8, 15, -2), generate_list));
        generate_list.Clear();
        appearing_platform.Add(new JumpingPlatform(new Vector3(-8, 15, 11), generate_list));
        generate_list.Clear();
    }
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (!generated && ok)
        {
            generated = true;
            GameObject g=(GameObject)Instantiate(Resources.Load("Prefabs/UnstablePlatform"), new Vector3(-13, 7, 7), new Quaternion(0, 0, 0, 0));
            g.GetComponent<UnstablePlatform>().lifetime = 5;
            g.GetComponent<UnstablePlatform>().index = -1;
            g = (GameObject)Instantiate(Resources.Load("Prefabs/UnstablePlatform"), new Vector3(-4, 9, 3), new Quaternion(0, 0, 0, 0));
            g.GetComponent<UnstablePlatform>().lifetime = 5;
            g.GetComponent<UnstablePlatform>().index = -1;
            g = (GameObject)Instantiate(Resources.Load("Prefabs/UnstablePlatform"), new Vector3(3, 11, 11), new Quaternion(0, 0, 0, 0));
            g.GetComponent<UnstablePlatform>().lifetime = 5;
            g.GetComponent<UnstablePlatform>().index = -1;
            g = (GameObject)Instantiate(Resources.Load("Prefabs/UnstablePlatform"), new Vector3(11, 13, 4), new Quaternion(0, 0, 0, 0));
            g.GetComponent<UnstablePlatform>().lifetime = 5;
            g.GetComponent<UnstablePlatform>().index = -1;
        }
	}

}
