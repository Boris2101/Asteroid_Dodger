using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperExaust : MonoBehaviour
{
    public ParticleSystem nozzleEffect;

    private void Awake()
    {
        nozzleEffect = GetComponent<ParticleSystem>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            nozzleEffect.Play();
        }
        else
        {
            nozzleEffect.Stop();
        }
    }
}
