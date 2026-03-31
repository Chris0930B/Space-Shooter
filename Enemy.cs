/////////////////////////////////////////////
//Assignment/Lab/Project: Space Shooter
//Name: Christopher Bentley
//Section: SGD Programming II (2026SP.SGD.213.4123)
//Instructor:Ven Lewis
//Date: 3/31/2026
/////////////////////////////////////////////
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public float health = 20f;
    public float speed = 5f;
    public Transform player;

    void Update()
    {
        transform.position = Vector3.MoveTowards(      ///// Moves the enemy towards the player's position at a constant speed
            transform.position,
            player.position,
            speed * Time.deltaTime
        );
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))    ///// Checks if the enemy collides with the player, and if so, it calls the TakeDamage method on the player's controller and destroys the enemy
        {
            collision.gameObject
                .GetComponent<PlayerController>()
                .TakeDamage(10);

            Destroy(gameObject);
        }
    }
    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            ScoreUI.instance.AddScore(10);
            Destroy(gameObject);
        }
    }
}

    