/*
 * Luke Lesimple
 * Challenge 2
 * Detect collisions with ball and dog
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GameObject.FindGameObjectWithTag("Healthsystem").GetComponent<HealthManager>().gainScore();
    }
}
