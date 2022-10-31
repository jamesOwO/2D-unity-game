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

    void TakeDamage(int damage)
    {
        currenthealth = currenthealth - damage;
        Debug.Log(currenthealth);
        if (currenthealth > 0)
        {
            //animator.SetTrigger("damage");
            animator.SetInteger("Health", currenthealth);
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
