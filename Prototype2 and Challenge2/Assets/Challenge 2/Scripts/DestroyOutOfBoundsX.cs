﻿/*
 * Luke Lesimple
 * Challenge 2
 * deletes dogs and balls that go out of bounds
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -50;
    private float bottomLimit = -5;


    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x <= leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        if (transform.position.y <= bottomLimit)
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Healthsystem").GetComponent<HealthManager>().takeDamage();
        }

    }
}
