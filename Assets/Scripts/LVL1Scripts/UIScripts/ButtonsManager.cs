using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsManager : MonoBehaviour
{
    static public ButtonsManager instance;
    public bool isGamePaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseButton();
        }
    }

    public void PauseButton()
    {
        if (!isGamePaused)
        {
            CubeDrop.instance.PauseAction();
            isGamePaused = true;
        }
        else
        {
            CubeDrop.instance.ResumeAction();
            CubeDrop.instance.Start();

            isGamePaused = false;
        }
    }
}
