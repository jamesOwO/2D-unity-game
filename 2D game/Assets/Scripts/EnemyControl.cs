using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyControl : MonoBehaviour
{
    public EnemyProjectile projectileprefab;
    public Transform LaunchOffset1;
    public Transform LaunchOffset2;
    public Transform LaunchOffset3;
    [SerializeField] private Health Playerhealth;
    [SerializeField] private Enemyhealth Enemyhealth;
    private float projectile1fire = 15;
    private float projectile2fire = 15;
    private float projectile3fire = 20;

    void Start()
    {
    }

    void Update()
    {
        Debug.Log(Time.time);
        if (Time.time > 15)
        {
            if (Playerhealth.currenthealth > 0 && Enemyhealth.enemycurrenthealth > 0)
            {
                
                if (Time.time > projectile1fire)
                {
                    Instantiate(projectileprefab, LaunchOffset1.position, transform.rotation);
                }
            }
        }

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
