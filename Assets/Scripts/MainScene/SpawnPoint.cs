using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject asteroid;
    void Start()
    {
        Instantiate(asteroid, transform.position, Quaternion.identity);
    }
}
