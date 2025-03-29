using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ScaleCube();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ScaleCube()
    {
        float xScale = Random.Range(1.0f, 3.0f);
        float zScale = Random.Range(1.0f, 3.0f);
        transform.localScale = new Vector3(xScale, transform.localScale.y, zScale);
    }

}
