using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxAsteroidSurface : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float startPoint;
    [SerializeField] float endPoint;


    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x <= endPoint)
        {
            Vector2 pos = new Vector2(startPoint,transform.position.y);
            transform.position = pos;
        }
    }
}
