using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void Quit()
    {
        Application.Quit();
    }
}
