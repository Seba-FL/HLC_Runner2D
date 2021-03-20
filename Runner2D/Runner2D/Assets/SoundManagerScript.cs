using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        audioSrc.clip = Resources.Load<AudioClip>("Bueno");
        //audioSrc.Play();
    }

    public static void playSound()
    {
        audioSrc.clip = Resources.Load<AudioClip>("Bueno");
        audioSrc.Play();
    }
}
