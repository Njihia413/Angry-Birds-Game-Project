using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static bool isON = false;
    public AudioSource mainSong;

    public AudioSource flyingSound;

    // Start is called before the first frame update
    void Start()
    {
        mainSong.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(isON)
        {
            flyingSound.Play();
            isON = false;
        }
    }
}
