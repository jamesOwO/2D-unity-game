using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Otherprojectile : MonoBehaviour
{
    public Animator animator;

    public float speed;

    // Update is called once per frame
    private void Update()
    {
        transform.position += -transform.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "enemy" || other.gameObject.tag == "border" || other.gameObject.tag == "Player" || other.gameObject.tag == "floor")
        {
            Destroy(gameObject);
        }
    }
}