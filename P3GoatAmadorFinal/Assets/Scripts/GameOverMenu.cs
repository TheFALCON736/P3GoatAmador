using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("Level1"); // Replace "Level1" with the appropriate scene name for your level
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Replace "MainMenu" with the appropriate scene name for your main menu
    }
}
