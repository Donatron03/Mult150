using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = 0f;
        float y = 0f;

        if (Input.GetKey(KeyCode.LeftArrow)) x = -.02f;
        if (Input.GetKey(KeyCode.RightArrow)) x = .02f;
        if (Input.GetKey(KeyCode.DownArrow)) y = -.02f;
        if (Input.GetKey(KeyCode.UpArrow)) y = .02f;

        // Move the sphere
        transform.Translate(x, y, 0);
    }
}
