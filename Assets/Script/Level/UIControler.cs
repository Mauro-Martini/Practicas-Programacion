using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIControler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public Slider pbar;
    public Button button;
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
        button.onClick.AddListener(GoBack);
    }
    void GoBack()
    {
        SceneManager.LoadScene("LevelSelection");
    }
}
