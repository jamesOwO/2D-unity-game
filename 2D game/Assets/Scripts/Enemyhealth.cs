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
    private float killtime;

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
            TakeDamage(1);
        }
    }

    void TakeDamage(int damage)
    {
        enemycurrenthealth = enemycurrenthealth - damage;
        if (enemycurrenthealth > 0)
        {
            //animator.SetTrigger("damage");
        }
        else
        {
            if (enemydead == false)
            {
                animator.SetTrigger("enemydie");
                enemydead = true;
                GetComponent<Movement>().enabled = false;

            }
        }
    }

}
