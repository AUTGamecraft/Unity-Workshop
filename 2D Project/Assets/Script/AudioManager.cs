using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioManager() { }

    private static AudioManager instance;
    public static AudioManager Instance
    {
        get
        {
            if(instance == null)
            {
                GameObject audio = Resources.Load("AudioManager") as GameObject;
                GameObject newAudio = Instantiate(audio);
                instance = newAudio.GetComponent<AudioManager>();
                DontDestroyOnLoad(instance);
            }

            return instance;
        }
    }

    public AudioSource music;

    public void Play()
    {
        music.Play();
    }

    public void Stop()
    {
        music.Stop();
    }
}
