    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    public AudioSource audioSource;
    public AudioClip audioClip;

    private bool isClipPlaying = false;

    private void Start()
    {
        audioSource.clip = audioClip;
    }

    public void ToggleSound()
    {
        if (!isClipPlaying) {
            isClipPlaying = true;
            audioSource.Play();
        }
        else {
            isClipPlaying = false;
            audioSource.Stop();
        }
    }
}
