using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spawnp2 : MonoBehaviour
  
{

    // Start is called before the first frame update
    void Start()
    {
       

        if (SceneManager.GetActiveScene().name == "w1 scene 2")
        {
            transform.position = new Vector2(0,-4);
            Debug.Log("penis"); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
