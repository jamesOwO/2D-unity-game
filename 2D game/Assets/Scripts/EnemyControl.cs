using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyControl : MonoBehaviour
{
    public EnemyProjectile projectileprefab;
    public Otherprojectile projectileprefab2;
    public Transform LaunchOffset1;
    public Transform LaunchOffset2;
    public Transform LaunchOffset3;
    public Transform LaunchOffset4;
    public Transform LaunchOffset5;
    public Transform LaunchOffset6;
    public Transform LaunchOffset7;
    public Transform LaunchOffset8;
    public Transform LaunchOffset9;
    public Transform LaunchOffset10;


    [SerializeField] private Health Playerhealth;
    [SerializeField] private Enemyhealth Enemyhealth;
    private float projectile1fire = 5;
    private float projectile2fire = 5;
    private float projectile3fire = 6;
    private float projectile4fire = 4;
    private float projectile5fire = 3;
    private float projectile6fire = 1;
    private float projectile7fire = 2;
    private float projectile8fire = 5;
    private float projectile9fire = 2;
    private float projectile10fire = 4;

    private bool stage2 = false;
    private bool stage3 = false;
    private float stage2time;
    private float stage3time;

    void Start()
    {
    }

    void Update()
    {
        if (Time.time > 5)
        {
            if (Playerhealth.currenthealth > 0 && Enemyhealth.enemycurrenthealth > 0)
            {
                if (Enemyhealth.enemycurrenthealth > 30)
                {
                    if (Time.time > projectile1fire)
                    {
                        Instantiate(projectileprefab, LaunchOffset1.position, transform.rotation);
                        projectile1fire = Time.time + 3;
                    }
                    if (Time.time > projectile2fire)
                    {
                        Instantiate(projectileprefab, LaunchOffset2.position, transform.rotation);
                        projectile2fire = Time.time + 2;
                    }
                    if (Time.time > projectile3fire)
                    {
                        Instantiate(projectileprefab, LaunchOffset3.position, transform.rotation);
                        projectile3fire = Time.time + 7;
                    }
                }

                if (Enemyhealth.enemycurrenthealth <= 30)
                {
                    if (stage2 == false)
                    {
                        stage2time = Time.time;
                        projectile4fire = projectile4fire + stage2time;
                        projectile5fire = projectile5fire + stage2time;
                        projectile6fire = projectile6fire + stage2time;
                        projectile7fire = projectile7fire + stage2time;
                        projectile8fire = projectile8fire + stage2time;
                        projectile9fire = projectile9fire + stage2time;
                        projectile10fire = projectile10fire + stage2time;

                        stage2 = true;
                    }
                    
                    
                    if (Time.time > projectile4fire)
                    {
                        Instantiate(projectileprefab2, LaunchOffset4.position, transform.rotation);
                        projectile4fire = Time.time + 5;
                    }
                    if (Time.time > projectile5fire)
                    {
                        Instantiate(projectileprefab2, LaunchOffset5.position, transform.rotation);
                        projectile5fire = Time.time + 2;
                    }
                    if (Time.time > projectile6fire)
                    {
                        Instantiate(projectileprefab2, LaunchOffset6.position, transform.rotation);
                        projectile6fire = Time.time + 11;
                    }
                    if (Time.time > projectile7fire)
                    {
                        Instantiate(projectileprefab2, LaunchOffset7.position, transform.rotation);
                        projectile7fire = Time.time + 4;
                    }

                    if (Time.time > projectile8fire)
                    {
                        Instantiate(projectileprefab2, LaunchOffset8.position, transform.rotation);
                        projectile8fire = Time.time + 8;
                    }

                    if (Time.time > projectile9fire)
                    {
                        Instantiate(projectileprefab2, LaunchOffset9.position, transform.rotation);
                        projectile9fire = Time.time + 7;
                    }
                    if (Time.time > projectile10fire)
                    {
                        Instantiate(projectileprefab2, LaunchOffset10.position, transform.rotation);
                        projectile10fire = Time.time + 3;
                    }

                }

            }
        }
    }
}
