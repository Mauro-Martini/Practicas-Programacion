using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MainMenuUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button button;


    // Update is called once per frame
    void Start()
    {
        button.onClick.AddListener(Play);
    }

    public void Play()
    {
        SceneManager.LoadScene("LevelSelection");
    }
}
