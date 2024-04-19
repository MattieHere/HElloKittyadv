using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    Rigidbody2D MyRigidbody;

    public void Fire(Vector3 direction)
    {

        MyRigidbody = GetComponent<Rigidbody2D>();

        MyRigidbody.AddForce(direction, ForceMode2D.Impulse);
        MyRigidbody.velocity = direction;




    }

    void OnCollisionEnter2D(Collision2D collision2d)
    {

        Destroy(gameObject);

    }

}