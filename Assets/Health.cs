using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public int health;
    public int numOfhearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;



    public void Heal()
    {

        health += 1;

    }

    public void TakeDamage()
    {

        health--;
    }



    private void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {

            if (health > numOfhearts)
            {

                health = numOfhearts;

            }


            if (i < health)
            {

                hearts[i].sprite = fullHeart;

            }
            else
            {

                hearts[i].sprite = emptyHeart;

            }



            if (i < numOfhearts)
            {

                hearts[i].enabled = true;

            }
            else
            {

                hearts[i].enabled = false;

            }
            if (health == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        }
    }


}