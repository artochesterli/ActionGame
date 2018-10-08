using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingPlatform{

    public Vector3 pos;
    public List<int> generate_list;
    public JumpingPlatform(Vector3 pos, List<int> list)
    {
        this.pos = pos;
        generate_list = new List<int>();
        for(int i = 0; i < list.Count; i++)
        {
            generate_list.Add(list[i]);
        }
    }


}
