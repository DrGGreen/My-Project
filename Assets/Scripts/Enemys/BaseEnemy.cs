using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    int MaxHp;
    int CurHp;

    public void TakeDammage(int dammage)
    {
        CurHp -= Math.Abs(dammage);
    }
    public void HealHp(int healing)
    {
        CurHp += Math.Abs(healing);
    }

    
}
