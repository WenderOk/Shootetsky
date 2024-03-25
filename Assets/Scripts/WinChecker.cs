using System.Collections.Generic;
using UnityEngine;

public class WinChecker : MonoBehaviour
{
    public GameObject WinScreen;
    public float Enemies;
    void Update()
    {
        if (Enemies >= 5)
        {
            WinScreen.SetActive(true);
            FindObjectOfType<PIGrotation>().enabled = true;
        }
    }
}
