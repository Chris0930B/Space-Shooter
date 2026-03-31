/////////////////////////////////////////////
//Assignment/Lab/Project: Space Shooter
//Name: Christopher Bentley
//Section: SGD Programming II (2026SP.SGD.213.4123)
//Instructor:Ven Lewis
//Date: 3/31/2026
/////////////////////////////////////////////
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;

    public float maxHealth = 100f;
    public float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");    ///// Gets the horizontal input axis (A/D  keys) to determine the player's movement direction on the horizontal plane
        float v = Input.GetAxis("Vertical");     ///// Gets the vertical input axis (W/S keys) to determine the player's movement direction on the vertical plane

        Vector3 move = new Vector3(h, 0, v);

        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)      ///////////// Checks if the player's health has dropped to zero or below, and if so, it calls the GameOver method on the GameManager instance to handle the game over state
        {
            GameManager.instance.GameOver();
        }
    }

    public void AddHealth(float amount)     //////// Increases the player's current health by the specified amount, ensuring that it does not exceed the maximum health limit
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}