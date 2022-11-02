using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public Animator animator;

    public float speed;
    private float health = 3;

    // Update is called once per frame
    private void Update()
    {
        transform.position += -transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "border")
        {
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "playerprojectile")
        {
            health = health - 1;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
