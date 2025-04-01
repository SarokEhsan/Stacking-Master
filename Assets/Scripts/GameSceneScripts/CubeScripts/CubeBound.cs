using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CubePosBound();
    }

    void CubePosBound()
    {
        float maxPoseXZ = 4.0f;
        if (transform.position.x > maxPoseXZ)
        {
            transform.position = new(maxPoseXZ, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -maxPoseXZ)
        {
            transform.position = new(-maxPoseXZ, transform.position.y, transform.position.z);
        }
        if (transform.position.z > maxPoseXZ)
        {
            transform.position = new(transform.position.x, transform.position.y, maxPoseXZ);
        }
        if (transform.position.z < -maxPoseXZ)
        {
            transform.position = new(transform.position.x, transform.position.y, -maxPoseXZ);
        }
    }
}
