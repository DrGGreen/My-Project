using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rapier : MonoBehaviour
{
    
    public void Attack()
    {
        RaycastHit hitEnemy;
        Physics.SphereCast(transform.position,0, Vector3.forward, out hitEnemy,2f);

        if(Physics.SphereCast(transform.position, 0, Vector3.forward, out hitEnemy, 2f))
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
