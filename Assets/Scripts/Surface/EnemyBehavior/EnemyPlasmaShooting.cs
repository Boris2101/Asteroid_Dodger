using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlasmaShooting : MonoBehaviour
{
    [SerializeField] GameObject plasmaProjectile;
    [SerializeField] Transform plasmaProjectileStartPosition;
    [SerializeField] float timer;
    public AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 3)
        {
            timer = 0;
            Shoot();
        }
    }

    void Shoot()
    {
        audioManager.PlaySFX(audioManager.enemyPlasmaShot);
        Instantiate(plasmaProjectile, plasmaProjectileStartPosition.position, Quaternion.identity);
    }
}
