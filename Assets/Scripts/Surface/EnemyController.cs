using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    GameObject Player;
    [SerializeField] float enemySpeed;
    [SerializeField] bool flip = true;
    [SerializeField] int _currentHealth;
    float distance;

    private void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
    
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, enemySpeed * Time.deltaTime);

        Vector3 scale = transform.localScale;

        if (Player.transform.position.x > transform.position.x)
        {
            scale.x = Mathf.Abs(scale.x) * (flip ? -1 : 1);
            
        }
        else
        {
            scale.x = Mathf.Abs(scale.x) * -1 * (flip ? -1 : 1);
            
        }

        transform.localScale = scale;

        if (_currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
    }

}
