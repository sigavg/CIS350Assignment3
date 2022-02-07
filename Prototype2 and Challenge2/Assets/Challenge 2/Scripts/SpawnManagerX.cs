/*
 * Luke Lesimple
 * Challenge 2
 * spawns balls
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomBallWithCoroutine());
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int index = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[index], spawnPos, ballPrefabs[0].transform.rotation);
    }
    IEnumerator SpawnRandomBallWithCoroutine()
    {
        while (true)
        {
            SpawnRandomBall();
            yield return new WaitForSeconds(Random.Range(3, 6));
        }
    }

}
