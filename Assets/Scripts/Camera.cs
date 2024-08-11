using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform oriantation;
    float xRot;
    float yRot;
    [SerializeField] Transform cameraPos;
    void Update()
    {
        float x = 400 * Input.GetAxisRaw("Mouse X") * Time.deltaTime;
        float y = 400 * Input.GetAxisRaw("Mouse Y") * Time.deltaTime;

        yRot += x;
        xRot -= y;
        xRot = Mathf.Clamp(xRot, -90f,90f);

        transform.rotation = Quaternion.Euler(xRot, yRot, 0);
        oriantation.rotation = Quaternion.Euler(xRot, yRot, 0);

        transform.position = cameraPos.position;
    }
}
