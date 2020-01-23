using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyLoop : MonoBehaviour
{
    public GameObject[] objects;
    int counter = 0;
    void Start()
    {
        //foreach (GameObject o in objects)
        //{
            //o.GetComponent<Renderer>().material.color = new Color(0, 0, 1, 1);
            Invoke("Kill", 1);
            objects[counter].GetComponent<Renderer>().material.color = new Color(0, 0, 1, 1);
        //print("destroyed! " + o);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Kill()
    {
        
        Destroy(objects[counter]);
        counter = counter + 1;
        objects[counter].GetComponent<Renderer>().material.color = new Color(0, 0, 1, 1);
        print(counter);
        Invoke("Kill", 1);
    }
}
