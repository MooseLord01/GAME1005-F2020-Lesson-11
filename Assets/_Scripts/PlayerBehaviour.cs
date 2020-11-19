using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            // Move right
            spriteRenderer.flipX = false;
        }

        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            // Move left
            spriteRenderer.flipX = true;

        }
    }
}
