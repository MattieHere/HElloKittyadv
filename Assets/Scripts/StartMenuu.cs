using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public Button switchButton;
    public string startW;

    void Start()
    {
        // Attach a method to the button's click event
        switchButton.onClick.AddListener(SwitchScene);
    }

    void SwitchScene()
    {
        // Load the target scene
        SceneManager.LoadScene(startW);
    }
}
