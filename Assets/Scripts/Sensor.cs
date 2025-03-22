using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    static public Sensor instance;
    public bool isGameOver = false;

    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        isGameOver = true;
    }
}
