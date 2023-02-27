using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    public int carwait = 10;
    bool keepPlaying = true;
    public float volume = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.PlayOneShot(audioClip, volume);
    }



    // Update is called once per frame
    void Update()
    {
        float m_Timer = 300.0f;
        m_Timer -= Time.deltaTime;

        if (m_Timer <= 0.0f)
        {
            // play sound
            m_Timer = 300.0f;
            audioSource.PlayOneShot(audioClip, volume);
        }

    }
}
