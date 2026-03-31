/////////////////////////////////////////////
//Assignment/Lab/Project: Space Shooter
//Name: Christopher Bentley
//Section: SGD Programming II (2026SP.SGD.213.4123)
//Instructor:Ven Lewis
//Date: 3/31/2026
/////////////////////////////////////////////
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum PowerType { Health, Speed }
    public PowerType type;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();

            if (type == PowerType.Health)
            {
                player.currentHealth += 20;   ///// Increases the player's health by 20 when they pick up a health power-up
            }

            if (type == PowerType.Speed)
            {
                player.moveSpeed += 5;    ///// Increases the player's movement speed by 5 when they pick up a speed power-up
            }

            Destroy(gameObject);
        }
    }
}
