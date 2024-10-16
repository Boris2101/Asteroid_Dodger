using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnPlsmPrjScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject EnemyPlasmaExplosParticles;
    Rigidbody2D _rb;
    [SerializeField] float bulletSpeed;
    [SerializeField] float lifeTime;
    [SerializeField] int bulletDamage;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = Player.transform.position - transform.position;
        _rb.velocity = new Vector2(direction.x, direction.y).normalized * bulletSpeed;

        float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rot);
    }

    void Update()
    {
        Destroy(gameObject, lifeTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        var surfacePlayerController = other.GetComponent<SurfacePlayerController>();
        if (surfacePlayerController != null)
        {
            surfacePlayerController.TakeDamage(bulletDamage);
            Instantiate(EnemyPlasmaExplosParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Surface") || other.CompareTag("PlasmaProjectile"))
        {
            Instantiate(EnemyPlasmaExplosParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
