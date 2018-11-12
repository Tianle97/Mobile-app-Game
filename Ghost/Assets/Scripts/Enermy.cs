using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enermy : MonoBehaviour {

    private const string SQUARE_TSG_TEXT = "SQUARE";

    [SerializeField]
    private int scoreValue = 10;

    [SerializeField]
    private AudioClip spawnClip;

    [SerializeField]
    private AudioClip hitClip;

    [SerializeField]
    private AudioClip crashClip;

    private SoundController soundController;

    //create public property
    public int ScoreValue { get { return scoreValue; } }


    //Enermy Killed Event handlers
    public delegate void EnermyKilled(Enermy enermy);

    //static event
    public static EnermyKilled EnermyKilledEvent;

    //private Methods
	private void Start () {
        soundController = SoundController.FindSoundController();
        PlayClip(spawnClip);
	}

    private void OnSquareEnter2D(Collider2D collider)
    {
        string tagType = gameObjec.tag;
        var player = collider.GetComponent<>
    }

    private void PlayClip(AudioClip spawnClip)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
