using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    static public CameraHandler instance;
    float b = 0;
    private void Awake()
    {
        instance = this;
    }
    public void CameraHeight()
    {
        float a = CubeDrop.instance.heightMinusOne;
        if (a > b)
        {
            transform.position += new Vector3(0.0f, 1.0f, 0.0f);
            b = a;
        }
    }
}
