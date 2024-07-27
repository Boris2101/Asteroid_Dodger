using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurfacePlayerController : MonoBehaviour
{
    #region Variables
    Rigidbody2D _rb;
    public HealthBar healthBar;
    public int maxHealth = 5;
    public int currentHealth;
    public int speed = 5;
    [SerializeField] bool facingRight = true;
    Vector2 _move;
    #endregion

    private void Awake()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        _rb = GetComponent<Rigidbody2D>();

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    private void Update()
    {
        _move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        _rb.velocity = _move * speed * Time.deltaTime;
        if (_move.x > 0 && !facingRight)
        {
            Flip();
        }
        else if(_move.x < 0 && facingRight)
        {
            Flip();
        }

    }

    private void Flip()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
