using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMaker : MonoBehaviour
{
    public Bullet Bullet;
    public Transform Shooter;
    public Transform Target;
    void Update()
    {
        Shoot();
    }
    void Shoot()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(Bullet,Shooter.position, Shooter.rotation);
        }
    }
}
