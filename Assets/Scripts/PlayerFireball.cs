using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireball : MonoBehaviour
{
    public GameObject prefab;

    void Update()
    {
        if (Input.GetButtonDown("Fire2")){
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
