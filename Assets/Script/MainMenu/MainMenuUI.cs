using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button button;
    public Button Quitbutton;


    // Update is called once per frame
    void Start()
    {
        button.onClick.AddListener(Play);
        Quitbutton.onClick.AddListener(QuitGame);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene("LevelSelection");
    }
}
