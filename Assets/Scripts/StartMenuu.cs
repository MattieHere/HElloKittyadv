using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public Button switchButton;
    public string startW;

    void Start()
    {
        
        switchButton.onClick.AddListener(SwitchScene);
    }

    void SwitchScene()
    {
       
        SceneManager.LoadScene(startW);
    }
}
