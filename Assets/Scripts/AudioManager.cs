using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("----- Audio Source-----")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;
    [SerializeField] AudioSource PlayerReplicasSource;
    public AudioSource NozzleSoundSource;
    

    [Header("-----Audio Clips-----")]
    public AudioClip backgroudMusic;
    public AudioClip playerPlasmaShot;
    public AudioClip enemyPlasmaShot;
    public AudioClip enemyRocketLaunch;
    public AudioClip nozzleSound;

    [Header("-----Player Replicas-----")]
    public AudioClip[] playerReplicasArray;

    private void Start()
    {
        musicSource.clip = backgroudMusic;
        musicSource.PlayDelayed(2f);
        NozzleSoundSource.clip = nozzleSound;
    }

    public void PlaySFX(AudioClip SFXEffect)
    {
        SFXSource.PlayOneShot(SFXEffect);
    }

    public void PlayNozzleSound()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (NozzleSoundSource.isPlaying == false)
            {
                NozzleSoundSource.Play();
            }
        }
        else
        {
            NozzleSoundSource.Stop();
        }
    }

    public void PlayNozzleSoundMainScene()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            if (NozzleSoundSource.isPlaying == false)
            {
                NozzleSoundSource.Play();
            }
        }
        else
        {
            NozzleSoundSource.Stop();
        }
    }

}
