using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GemManager : MonoBehaviour
{
    public int gemCount;
    public int checkQuestion;
    public bool doorWater;
    public bool doorFire;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gemCount == 6 && checkQuestion == 1 && doorWater && doorFire)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            switch (currentSceneIndex)
            {
                case 1:
                    SceneManager.LoadScene(2);
                    break;
                case 2:
                    SceneManager.LoadScene(3);
                    break;
                case 3:
                    SceneManager.LoadScene(4);
                    break;
                case 4:
                    SceneManager.LoadScene(5);
                    break;
                default: break;
            }

        }
    }
}
