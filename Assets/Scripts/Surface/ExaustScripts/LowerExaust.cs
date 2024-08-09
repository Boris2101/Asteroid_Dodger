using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerExaust : MonoBehaviour
{
    public ParticleSystem nozzleEffect;

    private void Awake()
    {
        nozzleEffect = GetComponent<ParticleSystem>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            nozzleEffect.Play();
        }
        else
        {
            nozzleEffect.Stop();
        }
       

    }
}
