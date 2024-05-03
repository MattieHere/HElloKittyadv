using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision2d)
    {

        GameObject otherGameObject = collision2d.gameObject;
        Health hitPlayer = otherGameObject.GetComponent<Health>();


        if (hitPlayer != null)
        {

            hitPlayer.TakeDamage();

        }


    }

}
