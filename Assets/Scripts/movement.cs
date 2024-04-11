using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class Player_movement : MonoBehaviour
{

    Rigidbody2D rigi;
    public float maxSpeed = 5f;
    Animator m_Animator;
    private SpriteRenderer spriteRenderer;
    public float spawnX;


    void Start()
    {
        transform.position = new Vector3(spawnX, -4);
        rigi = GetComponent<Rigidbody2D>();
        m_Animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput == 0f)
        {

            Vector2 currentVelocity = rigi.velocity;
            currentVelocity.x = 0f;
            rigi.velocity = currentVelocity;
        }



        if (Input.GetKeyDown(KeyCode.D) && rigi.velocity.x < horizontalInput)
        {
            rigi.AddForce(new Vector2(5, 0), ForceMode2D.Force);

            m_Animator.SetFloat("Run", horizontalInput);
        }
        else if (Input.GetKeyDown(KeyCode.A) && rigi.velocity.x > -horizontalInput)
        {
            rigi.AddForce(new Vector2(-5, 0), ForceMode2D.Force);

            m_Animator.SetFloat("Run", -horizontalInput);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rigi.velocity.y) < 0.01f)
        {
            rigi.AddForce(new Vector2(0, 250), ForceMode2D.Force);
        }
        else
        {
            m_Animator.SetFloat("Run", horizontalInput);
            rigi.AddForce(new Vector2(0, 0), ForceMode2D.Force);
        }

        Vector2 movement = new Vector2(horizontalInput, 0f);
        rigi.velocity = new Vector2(movement.x * maxSpeed, rigi.velocity.y);

        if (horizontalInput < 0f)
        {
            spriteRenderer.flipX = false;
        }
        else if (horizontalInput > 0f)
        {
            spriteRenderer.flipX = true;
        }

    }
}
