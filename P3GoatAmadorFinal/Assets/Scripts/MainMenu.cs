using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private string level1SceneName = "Level1";

    [SerializeField]
    private string level2SceneName = "Level2";

    public void StartLevel1()
    {
        SceneManager.LoadScene(level1SceneName);
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene(level2SceneName);
    }
}
