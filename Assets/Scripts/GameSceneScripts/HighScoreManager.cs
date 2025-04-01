using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreManager : MonoBehaviour
{
    static public HighScoreManager instance;
    public string tempPlayerName;
    public string playerName;
    public int highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore = 0;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerName + highScore);
    }

    public void HighScoreSubmit()
    {
        if (PointManager.instance.totalPoints >  highScore)
        {
            playerName = tempPlayerName;
            highScore = PointManager.instance.totalPoints;
        }
    }
}
