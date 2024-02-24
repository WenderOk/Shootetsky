
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    public float LifeTime;
    public float Damage=10;
    private void Start()
    {
        Invoke("DestroyBullet", LifeTime);
    }
    private void FixedUpdate()
    {
        MoveFixedUpdate();
    }

    private void OnCollisionEnter(Collision collision)
    {
        EnemyDamage(collision);
        DestroyBullet();
    }

    private void EnemyDamage(Collision collision)
    {
        var EnemyHealth = collision.gameObject.GetComponent<EnemyHealth>();
        if (EnemyHealth != null) EnemyHealth.DealDamage(Damage);
    }
    private void DestroyBullet() { Destroy(gameObject); }
    private void MoveFixedUpdate() { transform.position += transform.forward * Speed * Time.fixedDeltaTime; }
}