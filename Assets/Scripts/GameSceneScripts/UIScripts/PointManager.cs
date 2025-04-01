using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    static public PointManager instance;
    public TextMeshProUGUI pointText;
    public int totalPoints = 0;
    // Start is called before the first frame update
    void Start()
    {
        pointText.text = "Points: 0";
    }

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = "Points: " + totalPoints;
    }
}
