using UnityEngine;
public class Player : MonoBehaviour
{
    public PlayerControler controler;
    private Rigidbody2D rb;

    public SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float velocityY = rb.linearVelocity.y;

        if (controler.jump)
        {
            if (controler.onFloor)
            {
                velocityY = controler.jumpForce;
            }
            controler.jump = false; // siempre se resetea
        }

        rb.linearVelocity = new Vector2(controler.speed, velocityY);
    }
}