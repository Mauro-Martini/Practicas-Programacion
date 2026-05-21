using UnityEngine;

public class LWallDetector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PlayerControler controler;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Suelo"))
        {
            controler.LWall = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Suelo"))
        {
            controler.LWall = false;
        }
    }
}

