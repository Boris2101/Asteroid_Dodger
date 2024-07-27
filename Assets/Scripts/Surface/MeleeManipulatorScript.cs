using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeManipulatorScript : MonoBehaviour
{
    #region Variables
    private float _timeBtwMelleAttack;
    [SerializeField] float _startTimeBtwMeleeAttack;
    public Transform meleeAttackPos;
    public LayerMask enemy;
    [SerializeField] float _meleeAttackRadious;
    [SerializeField] int _meleeDamage;
    public Animator animator;
    #endregion

    void Start()
    {
        
    }

    
    void Update()
    {
        if (_timeBtwMelleAttack <= 0)
        {
            if (Input.GetMouseButton(1))
            {
                animator.SetTrigger("MeleeAttack");
                Collider2D[] enemies = Physics2D.OverlapCircleAll(meleeAttackPos.position, _meleeAttackRadious, enemy);
                for (int i = 0; i < enemies.Length; i++)
                {
                    enemies[i].GetComponent<EnemyController>().TakeDamage(_meleeDamage);
                }
            }
            _timeBtwMelleAttack = _startTimeBtwMeleeAttack;
        }
        else
        {
            _timeBtwMelleAttack -= Time.deltaTime;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(meleeAttackPos.position, _meleeAttackRadious);
    }
}
