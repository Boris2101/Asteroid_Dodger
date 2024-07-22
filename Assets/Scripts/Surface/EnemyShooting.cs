using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletStartPosition;
    [SerializeField] float timer;
    void Start()
    {
        
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
        Instantiate(bullet, bulletStartPosition.position, Quaternion.identity);
    }
}
