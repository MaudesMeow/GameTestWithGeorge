using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMain : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D playerRB;

    public float speed = .02f;


    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        Vector2 moveHorizontal = transform.right * movement.x;
        Vector2 moveVertical = transform.up * movement.y;

        Vector2 velocity = (((moveHorizontal+moveVertical)).normalized * speed);

        playerRB.MovePosition(playerRB.position + velocity * Time.fixedDeltaTime);
    }
}
