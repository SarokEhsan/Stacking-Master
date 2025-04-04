using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MenuHighScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI menuHighScoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        DataManager.instance.LoadData();

        if (HighScoreManager.instance.playerName == null)
        {
            HighScoreManager.instance.playerName = string.Empty;
            menuHighScoreDisplay.text = "Highscore: nobody \"0\"";
        }
        else
        {
            menuHighScoreDisplay.text = "Highscore: " + HighScoreManager.instance.playerName + " \"" + HighScoreManager.instance.highScore + "\"";
        }

    }

    private void Awake()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
