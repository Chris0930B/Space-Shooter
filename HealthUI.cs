/////////////////////////////////////////////
//Assignment/Lab/Project: Space Shooter
//Name: Christopher Bentley
//Section: SGD Programming II (2026SP.SGD.213.4123)
//Instructor:Ven Lewis
//Date: 3/31/2026
/////////////////////////////////////////////
using UnityEngine;
using TMPro;

public class HealthUI : MonoBehaviour
{
    public PlayerController player;
    public TextMeshProUGUI healthText;   

    void Update()
    {
        healthText.text = "Health: " + player.currentHealth.ToString("0");    ////// Updates the health display with the player's current health
    }
}