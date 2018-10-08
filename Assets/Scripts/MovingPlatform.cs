using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MovingPlatform : MonoBehaviour
{
    public int index;
    public bool launched;
    public Vector3 speed;
    private int Translation_index;
    private List<Translation> Translationlist;
    // Use this for initialization
    void Start ()
	{
        launched = false; ;
        Translation_index = 0;
        Translationlist = new List<Translation>();
        if (index == 0)
        {
            Translationlist.Add(new Translation(new Vector3(12, 1, 0), new Vector3(-2, 1, 0), 4));
            Translationlist.Add(new Translation(new Vector3(-2, 1, 0), new Vector3(12, 1, 0), 4));
        }
        else if (index == 1)
        {
            Translationlist.Add(new Translation(new Vector3(-12, 9, 9), new Vector3(-12, 3, 0), 4));
            Translationlist.Add(new Translation(new Vector3(-12, 3, 0), new Vector3(-12, 9, 9), 4));
        }
        else
        {
            Translationlist.Add(new Translation(new Vector3(-2, 10, 9), new Vector3(12, 10, 9), 4));
            Translationlist.Add(new Translation(new Vector3(12, 10, 9), new Vector3(-2, 10, 9), 4));
            Translationlist.Add(new Translation(new Vector3(-2, 10, 9), new Vector3(12, 10, 9), 4));
            Translationlist.Add(new Translation(new Vector3(12, 10, 9), new Vector3(-2, 10, 9), 4));
        }
        //StartCoroutine(Move());
    }
	
	// Update is called once per frame
	void Update () {
        if (Controller.ok && !launched)
        {
            launched = true;
            StartCoroutine(Move());
        }
	}
	IEnumerator Move()
	{
        while (true)
        {
            speed = (Translationlist[Translation_index].end_pos - Translationlist[Translation_index].start_pos) / Translationlist[Translation_index].time;
            transform.position += speed * Time.deltaTime;
            if(Vector3.Dot(transform.position- Translationlist[Translation_index].end_pos, speed) > 0)
            {
                Translation_index = (Translation_index + 1) % Translationlist.Count;
                if (Translation_index == 0)
                {
                    speed = new Vector3(0, 0, 0);
                    break;
                }
                transform.position = Translationlist[Translation_index].start_pos;
            }
            yield return null;
        }


    }
}
