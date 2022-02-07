/*
 * Luke Lesimple
 * Prototype 2
 * functionality for shooting food
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPrefab : MonoBehaviour
{
    public GameObject toShoot;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(toShoot, transform.position, toShoot.transform.rotation);
        }
    }
}
