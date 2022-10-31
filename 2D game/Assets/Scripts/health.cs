using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    [SerializeField] private float startinghealth;
    private float currenthealth;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = startinghealth;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void TakeDamage(float _damage)
    {
        currenthealth = Mathf.Clamp(currenthealth - _damage, 0, startinghealth);


        if (currenthealth > 0)
        {
            anim.SetTrigger("damaged");
            anim.SetFloat("health", currenthealth);
        }
        else
        {
            anim.SetTrigger("die");
        }
    }
}
