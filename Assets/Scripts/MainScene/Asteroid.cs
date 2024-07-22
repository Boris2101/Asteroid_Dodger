using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    [SerializeField] float asteroidSpeed;
    [SerializeField] int damage;
    public GameObject CollisionWithAsteroid;
 
    void Update()
    {
        transform.Translate(Vector2.left * asteroidSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController playerController = other.GetComponent<PlayerController>();
        if (playerController != null)
        {
            Instantiate(CollisionWithAsteroid, transform.position, Quaternion.identity);
            playerController.TakeDamage(damage);
            playerController.BadWords();
            Destroy(gameObject);
        }
    }
}
