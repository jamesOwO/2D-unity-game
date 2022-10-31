using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Health playerhealth;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    private void Update()
    {
        animator.SetInteger("Health", playerhealth.currenthealth);
    }
}
