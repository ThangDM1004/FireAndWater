using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestionMenu : MonoBehaviour
{
    public GemManager gm;
    [SerializeField] GameObject questionMenu;
    [SerializeField] Button closeBtn_correct;
    [SerializeField] Button closeBtn_wrong;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindObjectOfType<GemManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerWater") || collision.gameObject.CompareTag("PlayerFire"))
        {
            questionMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void Correct()
    {
        closeBtn_correct.gameObject.SetActive(true);
    }
    public void Wrong()
    {
        closeBtn_wrong.gameObject.SetActive(true);
    }
    public void Resume()
    {
        questionMenu.SetActive(false);
        Time.timeScale = 1;
        gm.checkQuestion++;
        Destroy(questionMenu);
    }
    public void ResumeWrong()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    // Update is called once per frame
}
