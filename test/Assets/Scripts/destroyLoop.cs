using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyLoop : MonoBehaviour
{
    public GameObject[] objects;
    void Start()
    {
        foreach (GameObject o in objects)
        {
            print("destroyed! " + o);
            Destroy(o);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
