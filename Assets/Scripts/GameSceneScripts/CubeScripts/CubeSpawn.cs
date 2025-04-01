using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawn : MonoBehaviour
{
    static public CubeSpawn instance;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cube, transform.position + RandomizeSpawnPos() + new Vector3(0.0f, 1.5f, 0.0f), Quaternion.identity);
    }

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (CubeDrop.instance.dropped && !Sensor.instance.isGameOver)
        {
            Instantiate(cube, transform.position + RandomizeSpawnPos(), Quaternion.identity);
            CubeDrop.instance.dropped = false;
        }
    }
    Vector3 RandomizeSpawnPos()
    {
        float randomXPos = Random.Range(-0.5f, 0.5f);
        float randomZPos = Random.Range(-0.5f, 0.5f);
        return new Vector3(randomXPos, 0.0f, randomZPos);
    }
}