using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    int MaxHp;
    [SerializeField] int CurHp;

    public void TakeDammage(int dammage)
    {
        CurHp -= Math.Abs(dammage);

        if(CurHp <= 0 ) // if the enemy has died
        {
            Destroy(gameObject);
        }
    }
    public void HealHp(int healing)
    {
        CurHp += Math.Abs(healing);
        if (CurHp > MaxHp) // if the enemy`s hp surpasses its max hp
        {
            CurHp = MaxHp;
        }
    }
    
    
}
