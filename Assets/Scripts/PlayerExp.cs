using UnityEngine;

public class PlayerExp : MonoBehaviour
{
    public float ShootUpRate=2;
    public float ExplosionUpRate=0.5f;
    public void AddExp(float value)
    {
      GetComponent<BulletMaker>().Damage += value/100* ShootUpRate;
      GetComponent<GrenadeMaker>().Damage += value/100* ExplosionUpRate;
    }
}
