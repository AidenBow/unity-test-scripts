using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatorLoop : MonoBehaviour
{
    public GameObject[] objects;
    void Start()
    {
        foreach(GameObject o in objects)
        {
            o.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
