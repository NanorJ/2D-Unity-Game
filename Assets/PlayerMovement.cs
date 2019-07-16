using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;
    public int health = 100;

    // Use this for initialization


    // Update is called once per frame
    void Update () {
        //this is going to change depending on the user input
        //A=-1, D=1
        //we can use debug.Log()
        horizontalMove=Input.GetAxisRaw("Horizontal") * runSpeed;//value between -1 and 1 multiplied by the speed 

        //checking for jump
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
            //we want crouch button to work just by holding it 
        }else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }
    public void Damaged(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            // Reload your scene using the new SceneManager
        }
    }

    private void FixedUpdate()
    {
        //Move our character 
        //multiply by the time : amount of time since last time called (insure movement of same amount every time called) 
        controller.Move(horizontalMove*Time.fixedDeltaTime,crouch,jump); // with no crouch and no jump
        jump = false;

    
    }

}
