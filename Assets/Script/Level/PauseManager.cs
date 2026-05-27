using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;
    public Button button;
    public GameObject image;
    void Start()
    {
        button.onClick.AddListener(PauseMenu);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu();
        }
    }

    public void PauseMenu()
    {
        if (isPaused)
        {
            Resume();
            image.SetActive(false);
        }
        else
        {
            Pause();
            image.SetActive(true);
        }
           
    }

    public void Pause()
    {
        Time.timeScale = 0;
        isPaused = true;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        isPaused = false;
    }
}