using UnityEngine;

public class RWallDetector : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public PlayerControler controler;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (System.Array.Exists(controler.tagsSuperficie, tag => tag == other.tag))
        {
            controler.RWall = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (System.Array.Exists(controler.tagsSuperficie, tag => tag == other.tag))
        {
            controler.RWall = false;
        }
    }
}

