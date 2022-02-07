/*
 * Luke Lesimple
 * Challenge 2
 * dog spawning and cooldown
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldowntimer = 0;
    public float cooldown = 2;

    // Update is called once per frame
    void Update()
    {
        cooldowntimer -= Time.deltaTime;
        
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && cooldowntimer <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldowntimer += cooldown;
        }


    }
}
