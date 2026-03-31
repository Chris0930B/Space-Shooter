/////////////////////////////////////////////
//Assignment/Lab/Project: Space Shooter
//Name: Christopher Bentley
//Section: SGD Programming II (2026SP.SGD.213.4123)
//Instructor:Ven Lewis
//Date: 3/31/2026
/////////////////////////////////////////////
using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;

    public Transform player;

    public float spawnDistance = 40f;   
    public float spawnWidth = 20f;      

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            int randomEnemy = Random.Range(0, enemies.Length);   ///// Randomly selects an enemy type from the array


            Vector3 spawnPos =
                player.position +   ////// Calculates a random spawn position in front of the player, within the specified width
                player.forward * spawnDistance +
                player.right * Random.Range(-spawnWidth, spawnWidth);

            GameObject enemy = Instantiate(enemies[randomEnemy], spawnPos, Quaternion.identity);

            enemy.GetComponent<Enemy>().player = player;

            yield return new WaitForSeconds(2f);   //////// Waits for 2 seconds before spawning the next enemy
        }
    }
}