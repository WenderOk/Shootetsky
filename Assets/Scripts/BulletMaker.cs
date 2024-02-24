using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMaker : MonoBehaviour
{
    public Bullet BulletPrefab;
    public Transform Shooter;
    void Start()
    {
        
    }
    void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(BulletPrefab,Shooter.position,Shooter.rotation);
        }
    }
}
