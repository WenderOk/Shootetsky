using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMaker : MonoBehaviour
{
    public float CoulDown;
    private float CurrentCoulDown;
    public Bullet Bullet;
    public float Damage = 10;
    public Transform Shooter;
    public Transform Target;
    public GameObject ShootFX;
    public AudioClip ShootSound;
    void Update()
    {
        CurrentCoulDown = Mathf.Max(0, CurrentCoulDown - 0.1f);
        Shoot();
    }
    void Shoot()
    {
        if(Input.GetMouseButtonDown(0)&& Input.GetMouseButton(1)&& CurrentCoulDown==0)
        {
            CurrentCoulDown = CoulDown;
            var Rot = Quaternion.AngleAxis(90, Vector3.up);
            Bullet.Damage = Damage;
            Instantiate(Bullet, Shooter.position, Shooter.rotation);
            ShootFX.GetComponent<ShootShaker>().MakeStress();
            ShootFX.GetComponent<AudioSource>().PlayOneShot(ShootSound);
        }
    }
}
