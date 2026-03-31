/////////////////////////////////////////////
//Assignment/Lab/Project: Space Shooter
//Name: Christopher Bentley
//Section: SGD Programming II (2026SP.SGD.213.4123)
//Instructor:Ven Lewis
//Date: 3/31/2026
/////////////////////////////////////////////
using UnityEngine;
using System.Collections;

public class PowerUpSpawner : MonoBehaviour
{
    public GameObject[] powerUps;
    public Transform player;

    public float spawnDistance = 35f;
    public float spawnWidth = 20f;

    void Start()
    {
        StartCoroutine(SpawnPowerUps());
    }

    IEnumerator SpawnPowerUps()    /////   spawn power-ups at regular intervals
    {
        while (true)
        {
            int rand = Random.Range(0, powerUps.Length);    ///// Randomly selects a power-up from the array

            Vector3 spawnPos =      //// Calculates a random spawn position in front of the player, within the specified width
                player.position +
                player.forward * spawnDistance +
                player.right * Random.Range(-spawnWidth, spawnWidth);

            Instantiate(powerUps[rand], spawnPos, Quaternion.identity);

            yield return new WaitForSeconds(8f);  ///////// Waits for 8 seconds before spawning the next power-up
        }
    }
}