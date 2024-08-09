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
    }
    public void HealHp(int healing)
    {
        CurHp += Math.Abs(healing);
        if (CurHp > MaxHp)
        {
            CurHp = MaxHp;
        }
    }

    
}
