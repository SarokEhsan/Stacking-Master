using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    static public Powerups instance;
    public int counterR = 0;
    public int counterD = 0;
    public TextMeshProUGUI rotatePowerupText;
    public TextMeshProUGUI deletePowerupText;
    public int rotatePowerupCounter;
    public int deletePowerupCounter;

    // Start is called before the first frame update
    void Start()
    {
        rotatePowerupCounter = 1;
        deletePowerupCounter = 0;
        rotatePowerupText.text = rotatePowerupCounter.ToString();
        deletePowerupText.text = deletePowerupCounter.ToString();
    }

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (rotatePowerupCounter < 0)
        {
            rotatePowerupCounter = 0;
        }
        if (deletePowerupCounter < 0)
        {
            deletePowerupCounter = 0;
        }

        if (counterR >= 10)
        {
            counterR -= 10;
            rotatePowerupCounter ++;
        }
        if (counterD >= 50)
        {
            counterD -= 50;
            deletePowerupCounter ++;
        }
        rotatePowerupText.text = rotatePowerupCounter.ToString();
        deletePowerupText.text = deletePowerupCounter.ToString();
        //Debug.Log(deletePowerupCounter);
    }
}
