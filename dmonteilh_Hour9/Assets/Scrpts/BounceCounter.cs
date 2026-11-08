using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int count = 0;

    void OnCollisionEnter(Collision collision)
    {
        count++;
        print("Bounce count: " + count);
    }
}
