using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExp : MonoBehaviour
{
    private float _currentExp = 0;
    private float _targetExp = 10;
    public void AddExp(float value)
    {
        _currentExp += value;
        if(_currentExp>=_targetExp)
        {
            _currentExp = 0;
            GetComponent<BulletMaker>().Damage += GetComponent<BulletMaker>().Damage/ 100 * 5;
            GetComponent<GrenadeMaker>().Damage += GetComponent<GrenadeMaker>().Damage / 100 * 2.5f;
            _targetExp += _targetExp/ 10;
        }
    }
}
