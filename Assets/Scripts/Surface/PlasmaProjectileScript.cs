using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaProjectileScript : MonoBehaviour
{
    [SerializeField] float _lifeTime;
    [SerializeField] float _speed;
    [SerializeField] float _distance;
    [SerializeField] int _damage;
    public LayerMask whatIsSolid;
    public GameObject plasmaExplose;
    void Start()
    {
        

    }

    
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, _distance, whatIsSolid);

        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Enemy1"))
            {
                hitInfo.collider.GetComponent<EnemyController>().TakeDamage(_damage);
            }
            Destroy(gameObject);
            Instantiate(plasmaExplose, transform.position, Quaternion.identity);
        }
        
        transform.Translate(Vector2.right * _speed * Time.deltaTime);

        Destroy(gameObject, _lifeTime);
    }
}
