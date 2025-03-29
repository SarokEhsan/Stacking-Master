using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CubePointDisplay : MonoBehaviour
{
    static public CubePointDisplay instance;
    public TextMeshPro cubePoint;
    //public int a1 = 0;
    //public int a2 = 0;
     Vector3 offset = new Vector3(0.0f, 1.5f, 0.0f);
    private void Awake()
    {
        instance = this;
    }
 
    public void PointDisplay()
    {
        Instantiate(cubePoint, transform.position + offset, cubePoint.transform.rotation);
        //cubePoint.text = "+" + (CubeSpawn.instance.a2);
        //CubeSpawn.instance.a1 = CubeSpawn.instance.a2;
    }
    public void PointPerCubeCalc()
    {
        //PointManager.instance.a2 = PointManager.instance.totalPoints;
        //Debug.Log("a2 = " + PointManager.instance.a2 + ", a1 = " + PointManager.instance.a1);
        //cubePoint.text = "+" + (PointManager.instance.a2 - PointManager.instance.a1);
        //PointManager.instance.a1 = PointManager.instance.a2;
    }
}
