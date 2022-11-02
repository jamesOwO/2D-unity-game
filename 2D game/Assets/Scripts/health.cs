using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Health : MonoBehaviour
{
    [SerializeField] private int startinghealth;
    [SerializeField] private Enemyhealth Enemyhealth;

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
            TakeDamage(5);
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
        
        if (currenthealth <= 0 && dead == false)
        {
            animator.SetTrigger("die");
            GetComponent<Movement>().enabled = false;
            dead = true;
        }
        if (Enemyhealth.enemycurrenthealth <= 0)
        {
            GetComponent<Movement>().enabled = false;
        }

    }
}
