using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Player player;
    public float jumpForce = 5f; // separado de speed
    public float speed = 7f;
    private float lspeed;
    private float rspeed;
    public bool onFloor = false;
    public bool LWall = false;
    public bool RWall = false;
    public bool jump = false;
    void Start()
    {
        lspeed = -speed;
        rspeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
        if (LWall)
        {
            speed = lspeed;
            player.spriteRenderer.flipX = true;
        } else if (RWall)
        {
            speed = rspeed;
            player.spriteRenderer.flipX = false;
        }

    }
}
