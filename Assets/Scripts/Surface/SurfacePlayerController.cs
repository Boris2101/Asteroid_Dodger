using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SurfacePlayerController : MonoBehaviour
{
    #region Fields
    Rigidbody2D _rb;
    public HealthBar healthBar;
    public CountScript countScript;
    public AudioManager audioManager;
    public int maxHealth = 5;
    public int currentHealth;
    public int speed = 5;
    [SerializeField] bool facingRight = true;
    public Vector2 _move;
    #endregion

    private void Awake()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        _rb = GetComponent<Rigidbody2D>();
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void AddHealth()
    {
        
    }

    private void Update()
    {
        _move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        audioManager.PlayNozzleSound();
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
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
