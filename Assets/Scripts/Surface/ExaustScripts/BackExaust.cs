using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackExaust : MonoBehaviour
{
    public GameObject player;
    public ParticleSystem nozzleEffect;

    private void Awake()
    {
        nozzleEffect = GetComponent<ParticleSystem>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            nozzleEffect.Play();
        }
        else
        {
            nozzleEffect.Stop();
        }
    }
}
