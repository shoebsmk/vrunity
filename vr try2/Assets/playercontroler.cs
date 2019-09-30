using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    public float speed = 57;
    //flag that sets weather we are moving or not
    bool isMoving = false;
    //destination/targets
    public Transform[] targets;
    int nextindex;
    // Start is called before the first frame update

    void Start()
    {
        //set player to first target
        transform.position = targets[0].position;
        //next dest is 1
        nextindex = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Cheack for input
        HandleInput();
        //move p
        HandleMovement();
        
    }

    private void HandleInput()
    {
        if (true == Input.GetButtonDown("Fire1"))
        {
            isMoving = !isMoving;
        }
       // else{ isMoving = false;}
    }

    private void HandleMovement()
    {
        if (isMoving)
        {
            //cal dist to target

            float dist = Vector3.Distance(transform.position, targets[nextindex].position);


            if (dist > 0)
            {
                float step = speed * Time.deltaTime;
                
                transform.position = Vector3.MoveTowards(transform.position, targets[nextindex].position, step);
            }
            else
            {
                
                nextindex++;
                if (nextindex>=targets.Length)
                { nextindex = 0; }
                isMoving = false;
            }
        }
    }
}
