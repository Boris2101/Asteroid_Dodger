using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExaustSound : MonoBehaviour
{
    public AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
        audioManager.NozzleSoundSource.clip = audioManager.nozzleSound;
    }

    private void Update()
    {
        
        audioManager.PlayNozzleSound();
    }

}
