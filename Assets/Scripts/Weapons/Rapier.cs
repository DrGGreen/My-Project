using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rapier : MonoBehaviour
{
    
    public void Attack()
    {
        RaycastHit hitEnemy;
        Physics.Raycast(transform.position, Vector3.forward, out hitEnemy, 5f);

            hitEnemy.transform.gameObject.GetComponent<BaseEnemy>()?.TakeDammage(10);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
    }
}
