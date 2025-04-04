using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    static public DataManager instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Serializable]
    public class SaveAndLoad
    {
        public string playerName;
        public int highScore;
    }
    public void SaveData()
    {
        SaveAndLoad data = new SaveAndLoad();
        data.playerName = HighScoreManager.instance.playerName;
        data.highScore = HighScoreManager.instance.highScore;
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/saveHighscore.json", json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/saveHighscore.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveAndLoad data = JsonUtility.FromJson<SaveAndLoad>(json);
            HighScoreManager.instance.playerName = data.playerName;
            HighScoreManager.instance.highScore = data.highScore;
        }
    }
}
