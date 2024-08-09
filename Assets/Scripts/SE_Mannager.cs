using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_Mannager : MonoBehaviour
{
    [SerializeField] AudioSource doubleJumpSound;
    public void DoubleJump()
    {
        doubleJumpSound.Play();
    }
}
