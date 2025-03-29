using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeFX : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip dropSoundFX;
    public ParticleSystem dropParticle;
    private bool dropDone;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        dropDone = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (dropDone)
        {
            audioSource.PlayOneShot(dropSoundFX);
            if (!Sensor.instance.isGameOver)
            {
                Instantiate(dropParticle, transform.position, transform.rotation);
            }
            dropDone = false;
        }
    }
}
