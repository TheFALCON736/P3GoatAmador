using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float totalTimeInSeconds = 300f; // Total time in seconds (5 minutes)
    public GameObject timerTextObject; // Reference to the GameObject containing the UI Text element

    private UnityEngine.UI.Text timerText; // Reference to the UI Text component
    private float currentTime; // Current time in seconds

    private void Start()
    {
        timerText = timerTextObject.GetComponent<UnityEngine.UI.Text>();
        currentTime = totalTimeInSeconds;
    }

    private void Update()
    {
        currentTime -= Time.deltaTime;

        // Update the UI text element with the remaining time
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        // Check if the time has run out
        if (currentTime <= 0f)
        {
            // Time has run out, perform game over or level failed actions
            SceneManager.LoadScene("GameOverScene"); // Replace "GameOverScene" with the appropriate scene name for your game over screen
        }
    }
}
