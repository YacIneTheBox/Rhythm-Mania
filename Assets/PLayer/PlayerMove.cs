using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int health;
    public float moveSpeed;
    Rigidbody2D rb;
    float speedx, speedy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speedx = Input.GetAxis("Horizontal") * moveSpeed;
        speedy = Input.GetAxis("Vertical") * moveSpeed;
        rb.linearVelocity = new Vector2(speedx, speedy);
    }
}
