using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Enemyhealthbar : MonoBehaviour
{
    [SerializeField] private Enemyhealth enemyhealth;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("Enemyhealth", enemyhealth.enemycurrenthealth);

    }
}
