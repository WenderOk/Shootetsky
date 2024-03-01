using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float _maxValue;
    public GameObject GameplayUI;
    public GameObject GameOverScreen;
    public float Value=100;
    public Image HPbar;
    
    private void Start()
    {
        _maxValue = Value;
    }

    public void DealDamage(float Damage)
    {
        Value -= Damage;
        HPbar.fillAmount = Value / _maxValue;
        if (Value <= 0)
        {
            PlayerDead();
        }
    }
    private void PlayerDead()
    {
        GameplayUI.SetActive(false);
        GameOverScreen.SetActive(true);
        GetComponent<CharacterController>().enabled = false;
        GetComponent<BulletMaker>().enabled = false;
        GetComponent<CameraRotation>().enabled = false;
        GetComponent<Animator>().enabled = false;
    }
}
