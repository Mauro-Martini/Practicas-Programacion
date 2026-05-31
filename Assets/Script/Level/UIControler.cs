using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIControler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public Slider pbar;
    public Button Backpause;
    public Button BackWin;

    public Player player;

    public float sliderV = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y > sliderV)
        {
            sliderV = player.transform.position.y;
            pbar.value = sliderV;
        }
        
            
    }
    void Start()
    {
        BackWin.onClick.AddListener(GoBack);
        Backpause.onClick.AddListener(GoBack);
    }
    void GoBack()
    {
        SceneManager.LoadScene("LevelSelection");
        Time.timeScale = 1;
    }
}
