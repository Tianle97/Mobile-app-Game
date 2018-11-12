using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundController : MonoBehaviour {

    //==field==
    private AudioSource audioSource;

    // == private Methods ==
    private void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
    //public Methods
    public void PlayOnShot(AudioClip clip)
    {
        if(clip)
        {
            audioSource.PlayOneShot(clip);
        }
    }

    public static SoundController FindSoundController()
    {
        var soundController = FindObjectOfType<SoundController>();
        if(!soundController )
        {
            Debug.LogWarning("No SoundController Found");
        }
        return soundController;
    }
		
	}
}
