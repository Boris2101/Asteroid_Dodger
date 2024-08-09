using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlasmaGun : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] float _offset;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Vector3 difference = Player.transform.position - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ + _offset);
    }
}
