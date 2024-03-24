using UnityEngine.AI;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float Value = 100;
    public Animator Anim;
    private PlayerExp playerExp;
    private void Start()
    {
        playerExp = FindObjectOfType<PlayerExp>();
    }
    public void DealDamage(float Damage)
    {
        playerExp.AddExp(Damage/10);
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
