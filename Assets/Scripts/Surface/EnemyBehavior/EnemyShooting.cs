using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletStartPosition;
    [SerializeField] float timer;
    public AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 2)
        {
            timer = 0;
            Shoot();
        }
    }

    void Shoot()
    {
        audioManager.PlaySFX(audioManager.enemyPlasmaShot);
        Instantiate(bullet, bulletStartPosition.position, Quaternion.identity);
    }
}
