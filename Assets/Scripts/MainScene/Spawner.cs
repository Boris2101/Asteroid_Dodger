using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnVariants;
    [SerializeField] float timeBtwSpawn;
    [SerializeField] float startTimeBtwSpawn;
    [SerializeField] float decreaseTime;
    [SerializeField] float minTime = 0.65f;
    void Update()
    {
       if (timeBtwSpawn <= 0)
       {
            int random = Random.Range(0, spawnVariants.Length);
            Instantiate(spawnVariants[random], transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
       }
       else
       {
            timeBtwSpawn -= Time.deltaTime;
       }
    }
}
