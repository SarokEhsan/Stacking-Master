using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    public GameObject cube;
    private Vector3 offset = new Vector3(0.0f, 1.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cube, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && CubeDrop.instance.dropped && !Sensor.instance.isGameOver)
        {
            Instantiate(cube, transform.position, Quaternion.identity);
            //transform.position += offset;
            CubeDrop.instance.dropped = false;
        }
    }
}