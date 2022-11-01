using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public Animator animator;

    public float speed;

    // Update is called once per frame
    private void Update()
    {
        transform.position += transform.right * speed;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "enemy" || other.gameObject.tag == "border")
        {
            Destroy(gameObject);
        }
    }
}
