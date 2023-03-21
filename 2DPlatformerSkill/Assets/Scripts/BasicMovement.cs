using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public float movementSpeed = 14f;
    public float jumpForce = 7f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * 300;

        rb.velocity = new Vector3(dirX * movementSpeed, rb.velocity.y);

        if (Input.GetButtonDown("Vertical") && Input.GetAxisRaw("Vertical") > 0)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce);
        }
        
    }
}
