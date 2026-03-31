/////////////////////////////////////////////
//Assignment/Lab/Project: Space Shooter
//Name: Christopher Bentley
//Section: SGD Programming II (2026SP.SGD.213.4123)
//Instructor:Ven Lewis
//Date: 3/31/2026
/////////////////////////////////////////////
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject gameOverPanel;

    void Awake()
    {
        instance = this;      
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);  ///////// Activates the game over panel
        Time.timeScale = 0;   /////// Pauses the game
    }

    public void Restart()   ///// Restarts the current scene
    {
        Time.timeScale = 1;   
        ScoreUI.instance.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  ///// Reloads the current scene
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}