using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionP2 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private string nextSceneName;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == ("hello kitty_1"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

        }

    }
}
