using UnityEngine.AI;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float Value = 100;
    public Animator Anim;
    public void DealDamage(float Damage)
    {
        Value -= Damage;
        Anim.SetTrigger("Damage");
        if (Value <= 0)
        {
            Anim.SetTrigger("Death");
            GetComponent<NavMeshAgent>().enabled = false;
            GetComponent<EnemyAI>().enabled = false;
            GetComponent<CapsuleCollider>().enabled = false;
        }
    }
}
