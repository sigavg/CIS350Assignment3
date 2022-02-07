/*
 * Luke Lesimple
 * Prototype 2
 * spawns animals
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 29;
    public bool gameOver = false;

    public GameObject[] toSpawn;

    public HealthSystem healthSystem;

    // Update is called once per frame
    void Start()
    {
        healthSystem = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();

        InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);

        StartCoroutine(SpawnRandomPrefabWithCoroutine());
    }

    private void Update()
    {
         if(Input.GetKeyDown(KeyCode.S))
         {
             SpawnRandomPrefab();
         }
    }
    void SpawnRandomPrefab()
    {
         int index = Random.Range(0, toSpawn.Length);

         Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

         Instantiate(toSpawn[index], spawnPos, toSpawn[index].transform.rotation);
    }
    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        yield return new WaitForSeconds(3f);
        while(!healthSystem.gameOver)
        {
            SpawnRandomPrefab();

            yield return new WaitForSeconds(1.5f);
        }
    }
}
