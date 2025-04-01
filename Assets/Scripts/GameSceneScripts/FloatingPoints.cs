using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingPoints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(pointDisappearRoutine());
    }

    private void Update()
    {
        gameObject.transform.position += new Vector3(0.0f, 1.5f * Time.deltaTime, 0.0f);
    }

    IEnumerator pointDisappearRoutine()
    {
        yield return new WaitForSeconds(1.5f);
        gameObject.SetActive(false);
    }
}
