using UnityEngine;
public class FloorDetector : MonoBehaviour
{
    public PlayerControler controler;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Suelo"))
        {
            controler.onFloor = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Suelo"))
        {
            controler.onFloor = false;
        }
    }
}