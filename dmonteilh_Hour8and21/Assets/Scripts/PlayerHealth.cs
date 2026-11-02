using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    int healthpoints = 3992;
    // Start is called before the first frame update
    void Start()
    {
        healthpoints = UsePotion(healthpoints);
        print(healthpoints);

        healthpoints = UsePotion(healthpoints);
        print(healthpoints);

        healthpoints = UsePotion(healthpoints);
        print(healthpoints);

        healthpoints = UsePotion(healthpoints);
        print(healthpoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int UsePotion(int health)
    {
        return health + 400;
    }
}
