using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    static public Sensor instance;

    public TextMeshProUGUI highScoreDisplay;
    public bool isGameOver = false;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Awake()
    {
        instance = this;
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        isGameOver = true;
        CubeDrop.instance.PauseAction();
        HighScoreManager.instance.HighScoreSubmit();
        highScoreDisplay.text = "Highscore: " + HighScoreManager.instance.playerName + " \"" + HighScoreManager.instance.highScore + "\"";
        audioSource.Play();
        DataManager.instance.SaveData();
    }
}
