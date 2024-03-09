using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float _maxValue;
    public GameObject GameplayUI;
    public GameObject GameOverScreen;
    public GameObject HealEffect;
    public float Value=100;
    public Image HPbar;
    public Animator Anim;
    
    private void Start()
    {
        _maxValue = Value;
    }

    public void DealDamage(float Damage)
    {
        Value -= Damage;
        HealthBarUpdate();
        if (Value <= 0)
        {
            PlayerDead();
        }
    }
    public void AddHealth(float amount)
    {
        Value += amount;
        Value = Mathf.Clamp(Value,0,_maxValue);
        HealthBarUpdate();
        HealEffect.GetComponent<ParticleSystem>().Play();
    }
    private void HealthBarUpdate() { HPbar.fillAmount = Value / _maxValue; }
    private void PlayerDead()
    {
        GameplayUI.SetActive(false);
        GameOverScreen.SetActive(true);
        GetComponent<CharacterController>().enabled = false;
        GetComponent<BulletMaker>().enabled = false;
        GetComponent<CameraRotation>().enabled = false;
        Anim.SetTrigger("Death");
    }
}
