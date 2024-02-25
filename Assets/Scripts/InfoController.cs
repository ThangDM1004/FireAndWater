using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoController : MonoBehaviour
{
    [SerializeField] GameObject InfoMenu;
    public void Pause()
    {
        InfoMenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void Resume()
    {
        InfoMenu.SetActive(false);
        Time.timeScale = 1;
    }
}
