
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float Value = 100;

    public void DealDamage(float Damage)
    {
        Value -= Damage;
        if (Value <= 0) Destroy(gameObject);
    }
}
