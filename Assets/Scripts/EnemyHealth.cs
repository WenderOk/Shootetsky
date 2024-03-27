using UnityEngine.AI;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float Value = 100;
    public Animator Anim;
    private PlayerExp playerExp;
    private WinChecker _checker;
    private void Start()
    {
        playerExp = FindObjectOfType<PlayerExp>();
        _checker = FindObjectOfType<WinChecker>();
    }
   void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) Death();
    }
    public void DealDamage(float Damage)
    {
        playerExp.AddExp(Damage);
        Value -= Damage;
        Anim.SetTrigger("Damage");
        if (Value <= 0)
        {
            Death();
        }
    }
    private void Death()
    {
        Anim.SetTrigger("Death");
        GetComponent<NavMeshAgent>().enabled = false;
        GetComponent<EnemyAI>().enabled = false;
        GetComponent<CapsuleCollider>().enabled = false;
        _checker.DeadEnemies++;
    }
}
