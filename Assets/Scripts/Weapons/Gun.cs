using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] GameObject Bullte;
    [SerializeField] GameObject Brain_Rot;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Gun_Fire();
        }

        Gun_Rot();
    }

    void Gun_Fire()
    {
        Instantiate(Bullte);
    }

    void Gun_Rot()
    {
        //gameObject.transform.rotation = Brain_Rot.transform.rotation;
        //gameObject.transform.localRotation = Brain_Rot.transform.localRotation;
        gameObject.transform.localRotation = new Vector3(Brain_Rot.transform.rotation.x, 0.0f, 0.0f);
    }
}
