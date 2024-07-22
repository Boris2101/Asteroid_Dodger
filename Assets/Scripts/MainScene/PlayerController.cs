using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Vector2 targetPosition;
    public GameObject[] replicasArray;
    public HealthBar healthBar;
    [SerializeField] float speed;
    [SerializeField] float YIncrement;
    [SerializeField] float minY;
    [SerializeField] float maxY;
    public int maxHealth = 5;
    public int currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); 
        
    }

    void Update()
    {

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxY)
        {
            targetPosition = new Vector2(transform.position.x, transform.position.y + YIncrement);
            
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minY) 
        { 
            targetPosition = new Vector2(transform.position.x, transform.position.y - YIncrement);
            
        }

    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
    public void BadWords()
    {
        int randomReplica = Random.Range(0, replicasArray.Length);
        Instantiate(replicasArray[randomReplica], transform.position, Quaternion.identity);
    }
}
