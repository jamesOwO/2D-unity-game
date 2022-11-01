using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Health : MonoBehaviour
{
    [SerializeField] private int startinghealth;
    public int currenthealth { get; private set; }
    public Animator animator;
    private bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = startinghealth;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            TakeDamage(1);
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "enemy" || other.gameObject.tag == "enemyprojectile")
        {
            TakeDamage(1);
        }
    }


    void TakeDamage(int damage)
    {
        currenthealth = currenthealth - damage;
        if (currenthealth > 0)
        {
            //animator.SetTrigger("damage");
        }
        else
        {
            if (dead == false)
            {
                animator.SetTrigger("die");
                GetComponent<Movement>().enabled = false;
                dead = true;
            }
        }
    }
}
