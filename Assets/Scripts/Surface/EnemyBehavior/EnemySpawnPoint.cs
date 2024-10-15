using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawnPoint : MonoBehaviour
{
    [SerializeField]Transform positionA;
    [SerializeField]Transform positionB;
    [SerializeField] float speed;
    Vector2 targetPosition;

    [SerializeField] GameObject[] enemies;
    [SerializeField] float timeBtwEnemySpawn = 10f;
    [SerializeField] float currentTimeBtwEnemySpawn;
    private void Awake()
    {
        targetPosition = positionA.position;
    }

    private void Update()
    {
        if (Vector2.Distance(transform.position, positionA.position) < .1f)
        {
            targetPosition = positionB.position;
        }
        if (Vector2.Distance(transform.position, positionB.position) < .1f)
        {
            targetPosition = positionA.position;
        }
        transform.position = Vector2.MoveTowards(transform.position,targetPosition, speed *  Time.deltaTime);

        if (currentTimeBtwEnemySpawn <= 0)
        {
            StartCoroutine(EnemySpawn());
            currentTimeBtwEnemySpawn = timeBtwEnemySpawn;
        }
        else if (currentTimeBtwEnemySpawn > 0)
        {
            currentTimeBtwEnemySpawn -= Time.deltaTime;
        }
    }

    IEnumerator EnemySpawn()
    {
        int numberOfEnemy = Random.Range(0, enemies.Length);
        Instantiate(enemies[numberOfEnemy], transform.position, Quaternion.identity);
        yield return null;
    }
}
