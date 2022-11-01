using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public EnemyProjectile projectileprefab;
    public Transform LaunchOffset1;
    public Transform LaunchOffset2;
    public Transform LaunchOffset3;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(projectileprefab, LaunchOffset1.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            Instantiate(projectileprefab, LaunchOffset2.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            Instantiate(projectileprefab, LaunchOffset3.position, transform.rotation);
        }

    }
}
