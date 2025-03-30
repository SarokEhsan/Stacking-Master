using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    bool a = true;

    // Update is called once per frame
    void Update()
    {
        if (a)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 0.05f);
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime * -0.05f);
        }

        if (transform.position.x > -0.9f)
        {
            a = false;
        }
        if (transform.position.x < -1.6f)
        {
            a = true;
        }
        

    }
}
