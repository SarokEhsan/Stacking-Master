using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour
{
    static public ButtonsManager instance;
    public GameObject gameOverUI;
    public GameObject pauseResumeUI;
    public bool isGamePaused = false;
    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
        pauseResumeUI.SetActive(false);
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
            PauseResumeButton();
        }
        if (Sensor.instance.isGameOver)
        {
            gameOverUI.SetActive(true);
        }
    }

    public void PauseResumeButton()
    {
        if (!isGamePaused)
        {
            pauseResumeUI.SetActive(true);
            CubeDrop.instance.PauseAction();
            isGamePaused = true;
        }
        else
        {
            pauseResumeUI.SetActive(false);
            CubeDrop.instance.ResumeAction();
            CubeDrop.instance.Start();

            isGamePaused = false;
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMainMenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
