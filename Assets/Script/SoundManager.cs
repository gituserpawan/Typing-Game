using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance {get; private set;}
   public AudioSource Source;

    private void Awake(){
        instance = this;
        Source = GetComponent<AudioSource>();
    }
    public void PlaySound(AudioClip _sound)
    {
        Source.PlayOneShot(_sound);
    }
}


