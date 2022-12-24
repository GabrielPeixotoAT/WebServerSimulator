using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ToStart()
    {
        SceneManager.LoadScene(1);
    }

    public void ToExit()
    {
        Application.Quit();
    }
}
