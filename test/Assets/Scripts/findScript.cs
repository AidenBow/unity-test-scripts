using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class findScript : MonoBehaviour
{
    GameObject foundObj;
    void Start()
    {
        foundObj = GameObject.Find("Capsule");
        Destroy(foundObj);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
