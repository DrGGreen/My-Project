using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PE_Mannager : MonoBehaviour
{
    [SerializeField] ParticleSystem doubleJumpParticle;

    public void DoubleJump()
    {
        doubleJumpParticle.transform.position = GameObject.Find("Player").transform.position + Vector3.down;
        doubleJumpParticle.Play();
    }
}
