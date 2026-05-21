using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelSelectionUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Button button;
    public Button button2;
    void testPlay()
    {
        SceneManager.LoadScene("Testlevel");
    }
    void GoBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
    // Update is called once per frame
    void Start()
    {
        button2.onClick.AddListener(GoBack);
        button.onClick.AddListener(testPlay);
    }
}
