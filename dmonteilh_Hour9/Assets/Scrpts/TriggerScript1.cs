using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class TriggerScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        print("Sphere entered " + gameObject.name);
    }

    void OnTriggerStay(Collider other)
    {
        print("Sphere is staying in " + gameObject.name);
    }

    void OnTriggerExit(Collider other)
    {
        print("Sphere exited " + gameObject.name);
    }
}
