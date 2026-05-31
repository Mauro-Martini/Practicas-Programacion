using UnityEngine;
using UnityEngine.UI;
public class WinControler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject winmenu;
    public GameObject Pausebutton;

    public void Win()
    {
        winmenu.SetActive(true);
        Pausebutton.SetActive(false);
        Time.timeScale = 0;

    }

    // Update is called once per frame

}
