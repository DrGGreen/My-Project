using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base_Spell : MonoBehaviour
{
    float spellCooldown;
    float spellCurCooldown;
    public void UseSpell()
    {
        if (spellCurCooldown == 0)
        {
            CastSpell();
            PlaySpellSound();
            spellCurCooldown = spellCooldown;
        }
    }
    void CastSpell()
    {

    }
    void PlaySpellSound()
    {

    }
    void Update()
    {
        if(spellCurCooldown > 0)
        {
            spellCurCooldown -= Time.deltaTime;
        }
    }
}
