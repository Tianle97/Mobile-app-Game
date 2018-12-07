using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundController : MonoBehaviour {

    // == fields ==
    private AudioSource audioSource;

    // == private methods ==

    private void Start () {
        audioSource = GetComponent<AudioSource>();
	}

    // == public methods ==
    public void PlayOneShot(AudioClip clip)
    {
        if(clip)
        {
            audioSource.PlayOneShot(clip);
        }
    }

    public static SoundController FindSoundController()
    {
        var soundController = FindObjectOfType<SoundController>();
        if (!soundController)
        {
            Debug.LogWarning("No Sound Controller Found, no sounds will play");
        }
        return soundController;
    }
}

