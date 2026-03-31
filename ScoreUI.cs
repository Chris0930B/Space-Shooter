/////////////////////////////////////////////
//Assignment/Lab/Project: Space Shooter
//Name: Christopher Bentley
//Section: SGD Programming II (2026SP.SGD.213.4123)
//Instructor:Ven Lewis
//Date: 3/31/2026
/////////////////////////////////////////////
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public static ScoreUI instance;

    public int score = 0;

    public TextMeshProUGUI scoreText;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateScoreUI();    /////// Initializes the score display at the start of the game
    }

    public void AddScore(int amount)
    {
        score += amount;    ////// Increases the score by the specified amount
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;   ////// Updates the score display with the current score
    }
}