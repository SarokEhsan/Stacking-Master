using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HighScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI highScoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highScoreDisplay.text = "Highscore: " + HighScoreManager.instance.playerName + " \"" + HighScoreManager.instance.highScore + "\"";
    }
}
