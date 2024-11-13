using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngotScript : MonoBehaviour
{
    [SerializeField] float _ingotSpeed;
    [SerializeField] float _lifeTime = 5f;
    Vector2 _move;
    void Awake()
    {
        float _randomX = Random.Range(-1f, 1f);
        float _randomY = Random.Range(-1f, 1f);
        _move = new Vector2(_randomX, _randomY);
        Destroy(gameObject, _lifeTime);

    }
    private void Update()
    {
        transform.Translate(_move * _ingotSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            EventManager.OnPickedUp();
            Destroy(gameObject);
        }
    }


}
