using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDrop : MonoBehaviour
{
    static public CubeDrop instance;
    [SerializeField] private float moveSpeed;
    public bool dropped = true;
    private Rigidbody cubeRb;
    public float heightMinusOne;
    private Color selectedColor;

    // Start is called before the first frame update
    void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
        ScaleCube();
        cubeRb.useGravity = false;
        selectedColor = GetComponent<Renderer>().material.color = CubeMat();
    }

    private void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !dropped)
        {
            cubeRb.useGravity = true;
        }
        if (!dropped)
        {
            PoseCube();
        }
        CubePoseBound();
        Debug.Log(heightMinusOne + 1);
    }

    void ScaleCube()
    {
        float xScale = Random.Range(1.0f, 3.0f);
        float zScale = Random.Range(1.0f, 3.0f);
        transform.localScale = new Vector3(xScale, transform.localScale.y, zScale);
    }

    void PoseCube()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.left * verticalInput * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * horizontalInput * moveSpeed * Time.deltaTime);
    }

    void CubePoseBound()
    {
        float maxPoseXZ = 4.0f;
        if (transform.position.x > maxPoseXZ)
        {
            transform.position = new(maxPoseXZ, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -maxPoseXZ)
        {
            transform.position = new(-maxPoseXZ, transform.position.y, transform.position.z);
        }
        if (transform.position.z > maxPoseXZ)
        {
            transform.position = new(transform.position.x, transform.position.y, maxPoseXZ);
        }
        if (transform.position.z < -maxPoseXZ)
        {
            transform.position = new(transform.position.x, transform.position.y, -maxPoseXZ);
        }
    }

    public Color CubeMat()
    {
        float green = Random.Range(0.0f, 1.0f);
        float aFactor = Random.Range(0.8f, 1.0f);
        Color color = new Color(1.0f, green, 0.0f, aFactor);
        return color;
    }
    private void OnCollisionEnter(Collision collision)
    {
        heightMinusOne = Mathf.FloorToInt(transform.position.y - GameObject.FindGameObjectWithTag("Ground").transform.position.y);
        dropped = true;
        CameraHandler.instance.CameraHeight();
    }
}
