using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupActive : MonoBehaviour
{
    public GameObject rotateActive;
    public GameObject deleteActive;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (RotatePowerup.instance.isShiftPressed)
        {
            rotateActive.SetActive(true);
        }
        else
        {
            rotateActive.SetActive(false);
        }

        if (DeletePowerup.instance.isXPressed)
        {
            deleteActive.SetActive(true);
        }
        else
        {
            deleteActive.SetActive(false);
        }
    }
}
