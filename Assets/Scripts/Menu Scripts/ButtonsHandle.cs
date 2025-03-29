using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ButtonsHandle : MonoBehaviour
{
    public GameObject confirmQuitButton;
    public GameObject cancelQuitButton;
    public GameObject instructionText;
    bool isInstructionVisible = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        confirmQuitButton.SetActive(true);
        cancelQuitButton.SetActive(true);
    }

    public void ConfirmQuitButton()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    public void CancelQuitButton()
    {
        confirmQuitButton.SetActive(false);
        cancelQuitButton.SetActive(false);

    }

    public void InstructionButton()
    {
        if (!isInstructionVisible)
        {
            instructionText.SetActive(true);
            isInstructionVisible = true;
        }
        else
        {
            instructionText.SetActive(false);
            isInstructionVisible = false;
        }
    }
}