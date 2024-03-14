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
            var Rot = Quaternion.AngleAxis(90, Vector3.up);
            Instantiate(Bullet, Shooter.position, Shooter.rotation);
                //(Shooter.rotation.x, Shooter.rotation.y + 90, Shooter.rotation.z);
        }
    }
}
