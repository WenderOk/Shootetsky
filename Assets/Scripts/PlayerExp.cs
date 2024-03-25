using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExp : MonoBehaviour
{
    public void AddExp(float value)
    {
      GetComponent<BulletMaker>().Damage += value/10;
      GetComponent<GrenadeMaker>().Damage += value/20;
    }
}
