using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translation{

    public Vector3 start_pos;
    public Vector3 end_pos;
    public float time;
    public Translation(Vector3 start_pos,Vector3 end_pos,float time)
    {
        this.start_pos = new Vector3(start_pos.x, start_pos.y, start_pos.z);
        this.end_pos = new Vector3(end_pos.x, end_pos.y, end_pos.z);
        this.time = time;
    }
}
