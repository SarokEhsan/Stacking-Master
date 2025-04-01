using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePowerup : MonoBehaviour
{
    static public RotatePowerup instance;
    bool rotatable;
    bool dropDone;
    public bool isShiftPressed = false;
    // Start is called before the first frame update
    void Start()
    {
        if (Powerups.instance.rotatePowerupCounter != 0)
        {
            rotatable = true;
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
        if (Input.GetKeyDown(KeyCode.LeftShift) && rotatable && Powerups.instance.rotatePowerupCounter > -1 && !ButtonsManager.instance.isGamePaused)
        {
            if (!isShiftPressed)
            {
                Powerups.instance.rotatePowerupCounter -= 1;
                isShiftPressed = true;
            }
            RotatePowerupFunc();
        }
    }

    void RotatePowerupFunc()
    {
        transform.Rotate(Vector3.up, 90.0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (dropDone)
        {
            rotatable = false;
            dropDone=false;
            isShiftPressed = false;
            //PowerupActive.instance.rotateActive.gameObject.SetActive(false);
        }
    }
}
