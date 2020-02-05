using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizonlatMove = 0;
    bool jump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Input.GetAxisRaw("Horizontal");

        horizonlatMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump")) { jump = true; }

    }

    void FixedUpdate(){
        // Move the character
        controller.Move(horizonlatMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
