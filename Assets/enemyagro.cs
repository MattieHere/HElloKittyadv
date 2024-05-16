using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyagro : MonoBehaviour
{
    [SerializeField]
    Transform hellokitty_0;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        

    }


    void Update()
    {

       

        float distToHellokitty_0 = Vector2.Distance(transform.position, hellokitty_0.position);

        if (distToHellokitty_0 < agroRange)
        {
            ChasePlayer();
        }
        else
        {
            StopChasingPlayer();
        }

       

    }
    void ChasePlayer()
    {
        if (transform.position.x < hellokitty_0.position.x)
        {
            rb2d.velocity = new Vector2(moveSpeed, 0);
        }
        else
        {
            rb2d.velocity = new Vector2(-moveSpeed, 0);
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput < 0f)
        {
            spriteRenderer.flipX = false;
        }
        else if (horizontalInput > 0f)
        {
            spriteRenderer.flipX = true;
        }
    }
    void StopChasingPlayer()
    {
        rb2d.velocity = new Vector2(0, 0);
    }
}