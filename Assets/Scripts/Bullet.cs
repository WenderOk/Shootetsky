
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed;
    public float LifeTime;
    private void Start()
    {
        Invoke("DestroyBullet", LifeTime);
    }
    void Update()
    {

    }
    private void FixedUpdate()
    {
        MoveFixedUpdate();
    }
    private void MoveFixedUpdate()
    {
        transform.position += -transform.right * Speed * Time.fixedDeltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        DestroyBullet();
    }
    private void DestroyBullet()
    {
        Destroy(gameObject);
    }
}