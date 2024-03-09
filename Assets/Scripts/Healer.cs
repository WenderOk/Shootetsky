using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : MonoBehaviour
{
    public int healthAmount = 30;

    private void Update()
    {
        transform.rotation = Quaternion.Euler(0, transform.rotation.y+ 5 * Time.deltaTime, 30);
    }
    void OnTriggerEnter(Collider other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.AddHealth(healthAmount);
            Destroy(gameObject);
        }
    }
}
