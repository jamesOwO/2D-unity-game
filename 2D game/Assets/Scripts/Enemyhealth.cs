using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;


public class Enemyhealth : MonoBehaviour
{
    [SerializeField] private int startinghealth;
    public int enemycurrenthealth { get; private set; }
    public Animator animator;
    private bool enemydead = false;

    void Start()
    {
        enemycurrenthealth = startinghealth;

    }

    private void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "playerprojectile")
        {
            if (enemycurrenthealth > 0)
            {
                TakeDamage(1);
            }
        }
    }

    void TakeDamage(int damage)
    {
        enemycurrenthealth = enemycurrenthealth - damage;
        {
            if (enemydead == false && enemycurrenthealth <= 0)
            {
                animator.SetTrigger("enemydie");
                enemydead = true;
            }
        }
    }
}
