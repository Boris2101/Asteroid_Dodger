using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("----- Audio Source-----")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-----Audio Clips-----")]
    public AudioClip backgroudMusic;
    public AudioClip playerPlasmaShot;
    public AudioClip enemyPlasmaShot;

    private void Start()
    {
        musicSource.clip = backgroudMusic;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip SFXEffect)
    {
        SFXSource.PlayOneShot(SFXEffect);
    }
}
