using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
//using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Skjuta : MonoBehaviour
{

    [SerializeField] private Cooldown cooldown;

    [SerializeField]
    private GameObject bulletPrefab;

    SpriteRenderer rend;

    Animator m_Animator;

    bool shooting;

    float shootDelay;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        m_Animator = GetComponent<Animator>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {

            if (!cooldown.isCoolingDown)
            {


                m_Animator.SetBool("Shoot", true);

                shooting = true;
            }

        }
        else
        {
            m_Animator.SetBool("Shoot", false);
        }

        if (shooting)
        {
            shootDelay += Time.deltaTime;
        }

        if (shootDelay > 0.1f)
        {
            float dir = -1f;
            if (rend.flipX)
            {
                dir = 1f;
            }


            // Instantiate the bullet at the current position with no rotation
            GameObject bulletGameObject = Instantiate(bulletPrefab, transform.position + new Vector3(dir, -0.1f, 0), Quaternion.identity);

            Bullet bulletcomponent = bulletGameObject.GetComponent<Bullet>();
            bulletcomponent.Fire(new Vector3(dir * 10, 0, 0));

            cooldown.StartCooldown();

            shootDelay = 0;

            shooting = false;
        }

    }

}