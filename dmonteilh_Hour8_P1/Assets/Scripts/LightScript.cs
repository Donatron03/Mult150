using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Light myLight;

    void Start()
    {

    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.L))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}
