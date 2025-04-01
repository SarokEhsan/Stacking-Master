using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    private Color selectedColor;

    // Start is called before the first frame update
    void Start()
    {
        selectedColor = GetComponent<Renderer>().material.color = CubeMat();
    }

    public Color CubeMat()
    {
        float green = Random.Range(0.0f, 1.0f);
        float aFactor = Random.Range(0.8f, 1.0f);
        Color color = new Color(1.0f, green, 0.0f, aFactor);
        return color;
    }
}
