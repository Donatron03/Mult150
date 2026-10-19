using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        for (int November = 1; November <= 30; November++)
        {
            if (November == 9)
            {
                print("Its my birthday!");
            }
            else
            {
                print(November);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
