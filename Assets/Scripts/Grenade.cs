
using UnityEngine;

public class Grenade : MonoBehaviour
{
    public float Damage;
    public float Delay=3;
    public GameObject ExplosionPrefab;
    public GameObject ExplosionFX;
    private void OnCollisionEnter(Collision collision)
    {
        Invoke("Explosion", Delay);
    }
    private void Explosion()
    {
        Destroy(gameObject);
        Instantiate(ExplosionFX, transform.position, Quaternion.identity);
        Instantiate(ExplosionPrefab,transform.position,Quaternion.identity);
        ExplosionPrefab.GetComponent<Explosion>().Damage = Damage;
    }
}
