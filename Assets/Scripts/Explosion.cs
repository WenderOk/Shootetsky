using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float MaxSize = 5;
    public float Speed = 1;
    public float Damage = 30;
    void Start()
    {
        transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += Vector3.one*Time.deltaTime*Speed;
        if (transform.localScale.x >= MaxSize) Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        var playerHealth = other.GetComponent<PlayerHealth>();
        if(playerHealth!=null) playerHealth.DealDamage(Damage/Vector3.Distance(other.transform.position,transform.position));
        
        var enemyHealth = other.GetComponent<EnemyHealth>();
        if (enemyHealth != null) enemyHealth.DealDamage(Damage);
    }
}
