using UnityEngine;

public class CameraMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Player player;
    public float speed;
    private Vector3 playerp;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Mathf.Abs(player.transform.position.y - transform.position.y);
        playerp = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, playerp, speed * Time.deltaTime);
    }
}
