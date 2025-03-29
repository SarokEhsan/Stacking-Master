using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDrop : MonoBehaviour
{
    static public CubeDrop instance;
    [SerializeField] private float moveSpeed;
    public bool dropped = true;
    public bool dropDone;
    public Rigidbody cubeRb;
    public float heightMinusOne;
    public int pointsToAdd;
    // Start is called before the first frame update
    public void Start()
    {
        cubeRb = GetComponent<Rigidbody>();
        dropDone = true;
        cubeRb.useGravity = false;
        cubeRb.AddForce(Vector3.down * 0.25f, ForceMode.Impulse);
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
        if (!dropped && !ButtonsManager.instance.isGamePaused)
        {
            PoseCube();
        }
        if (gameObject.GetComponent<MeshRenderer>().material.color == Color.white)
        {
            //gameObject.SetActive(false);

        }

    }

    void PoseCube()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.left * verticalInput * moveSpeed * Time.deltaTime, Space.World);
        transform.Translate(Vector3.forward * horizontalInput * moveSpeed * Time.deltaTime, Space.World);
    }

    public int CubePointCalc()
    {
        float point = transform.localScale.x * transform.localScale.z;
        if (point < 4.0f)
        {
            return 1;
        }
        else if (point > 6.25f)
        {
            return 3;
        }
        else { return 2; }
    }

    public void PauseAction()
    {
        cubeRb.constraints = RigidbodyConstraints.FreezePosition;
    }
    public void ResumeAction()
    {
        cubeRb.constraints = RigidbodyConstraints.None;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (dropDone)
        {
            cubeRb.useGravity = true;
            heightMinusOne = Mathf.FloorToInt(transform.position.y - GameObject.FindGameObjectWithTag("Ground").transform.position.y);
            dropped = true;
                CameraHandler.instance.CameraHeight();
            if (!Sensor.instance.isGameOver)
            {
                PointManager.instance.totalPoints += CubePointCalc();
                Powerups.instance.counterR += CubePointCalc();
                Powerups.instance.counterD += CubePointCalc();
            }
            dropDone = false;
        }
    }
}
