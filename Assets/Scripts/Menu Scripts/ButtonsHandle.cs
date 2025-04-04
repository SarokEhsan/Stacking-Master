using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ButtonsHandle : MonoBehaviour
{
    public GameObject confirmQuitButton;
    public GameObject cancelQuitButton;
    public GameObject instructionText;
    public GameObject nameUI;
    public TMP_InputField nameInput;
    public TextMeshProUGUI menuHighScoreDisplay;
    bool isInstructionVisible = false;
    // Start is called before the first frame update
    void Start()
    {
        nameInput.text = null;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartButton()
    {
        nameUI.SetActive(true);
    }

    //inputfield code
    public void SubmitName()
    {
        SceneManager.LoadScene(1);
        HighScoreManager.instance.tempPlayerName = nameInput.text;
    }
    public void CancelName()
    {
        nameUI.SetActive(false);
        nameInput.text = null;
    }
    //

    //Exit code
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
    //

    //display instruction code
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
    //

    //reset highscore
    public void HighScoreReset()
    {
        HighScoreManager.instance.playerName = null;
        HighScoreManager.instance.highScore = 0;
        DataManager.instance.SaveData();
        menuHighScoreDisplay.text = "Highscore: nobody \"0\"";
    }
    //
}