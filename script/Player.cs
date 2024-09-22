using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Rigidbody2D rb;
    private Vector2 playermobement;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        float directionX = Input.GetAxisRaw("Horizontal");
       
        

        playermobement = new Vector2(directionX, directionY).normalized;

    }
    private void FixedUpdate()
    {
        rb.velocity = playermobement * speed;
        //rb.velocity = new Vector2(0, playermobement.y * speed);

    }
}
