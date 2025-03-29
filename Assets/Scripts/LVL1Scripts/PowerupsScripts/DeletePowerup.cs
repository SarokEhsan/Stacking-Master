using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class DeletePowerup : MonoBehaviour
{
    static public DeletePowerup instance;
    bool deleteAvailable;
    bool dropDone;
    public bool isXPressed = false;
    RaycastHit hit;

    // Start is called before the first frame update
    void Start()
    {
        if (Powerups.instance.deletePowerupCounter != 0)
        {
            deleteAvailable = true;
        }
        dropDone = true;

    }

    private void Awake()
    {
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {

        Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit);
        if (Input.GetKeyDown(KeyCode.X) && deleteAvailable && Powerups.instance.deletePowerupCounter > 0 && !ButtonsManager.instance.isGamePaused)
        {
            if (!isXPressed)
            {
                Powerups.instance.deletePowerupCounter -= 1;
                isXPressed = true;
            }
            CubeDrop.instance.PauseAction();
        }
        
        if (Input.GetMouseButtonDown(0) && isXPressed)
        {
            if (hit.transform.gameObject.tag != "Ground")
            {
                hit.transform.gameObject.SetActive(false);
                isXPressed = false;
                CubeDrop.instance.ResumeAction();
                CubeDrop.instance.Start();
            }
            //hit.transform.gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (dropDone)
        {
            deleteAvailable = false;
            dropDone = false;
            isXPressed = false;
        }
    }

}
