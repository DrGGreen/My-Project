using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Apple;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] SE_Mannager SE_Mannager;
    [SerializeField] PE_Mannager PE_Mannager;

    [SerializeField] Image HealthBar;

    float gravity = -9.81f;
    private float movementSpeed = 3f;
    private CharacterController controller;
    [SerializeField] Vector3 playerVelocity;
    public Transform playerCam;
    [SerializeField] Vector3 movement;
    private bool doubleJump = true;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        Movement();
        UpdateHealthBar();
        playerCam.transform.position = GameObject.Find("Camera Location").transform.position;
    }
    private void Movement()
    {
        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //Vector3 movement = Quaternion.Euler(0, playerCam.transform.eulerAngles.y, 0) * new Vector3(Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime, 0, Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime);
        
        
        if (Input.GetKey(KeyCode.LeftShift))
            movement = Quaternion.Euler(0, playerCam.transform.eulerAngles.y, 0) * new Vector3(Input.GetAxis("Horizontal") * 2 * movementSpeed * Time.deltaTime, 0, Input.GetAxis("Vertical") * 2 * movementSpeed * Time.deltaTime);
        else
            movement = Quaternion.Euler(0, playerCam.transform.eulerAngles.y, 0) * new Vector3(Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime, 0, Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime);

        controller.Move(movement);



        if (Physics.Raycast(transform.position, Vector3.down, 1f))
        {
            playerVelocity.y = 0;
            if (Input.GetButtonDown("Jump"))
                playerVelocity.y += -0.5f * gravity;
            doubleJump = true;
        }
        else
        {
            playerVelocity.y += gravity * Time.deltaTime;
            if (Input.GetButtonDown("Jump"))
                DoubleJump();

        }
        controller.Move(playerVelocity * Time.deltaTime);
    }
    private void DoubleJump()
    {

        if(doubleJump)
        {
            playerVelocity.y = -0.5f * gravity;
            doubleJump = false;
            SE_Mannager.DoubleJump();
            PE_Mannager.DoubleJump();
        }
        else
        {

        }
    }


    int MaxHp = 100;
    public int CurHp = 100;

    public void TakeDammage(int dammage)
    {
        CurHp -= Math.Abs(dammage);
    }
    public void HealHp(int healing)
    {
        CurHp += Math.Abs(healing);
        if(CurHp > MaxHp)
        {
            CurHp = MaxHp;
        }
    }

    private void UpdateHealthBar()
    {
        //Health bar get smaller until reach health
        if((float)CurHp / 100 <= HealthBar.transform.localScale.y)
        {
            //if(CurHp > 20)
            HealthBar.transform.localScale -= new Vector3(0,(float)CurHp / 100, 0) * Time.deltaTime;
            //else
                //HealthBar.transform.localScale -= new Vector3(0, (float)(50 / 100), 0) * Time.deltaTime;
        }
        //Health bar get bigger until reach health
        if ((float)CurHp / 100 >= HealthBar.transform.localScale.y)
        {
            HealthBar.transform.localScale += new Vector3(0, (float)CurHp / 100, 0) * Time.deltaTime;
        }

        //set position to stay with scale
        HealthBar.transform.localPosition = new Vector3(HealthBar.transform.localPosition.x , -165/2 * HealthBar.transform.localScale.y - 200, 0);
    }
}
