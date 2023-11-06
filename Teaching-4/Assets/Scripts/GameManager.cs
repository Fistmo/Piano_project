using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject PauseCanva;
    public GameObject MyTestCanva;
    public GameObject RandomCanva;

    public void Pause()
    {
        MyTestCanva.SetActive(false);
        PauseCanva.SetActive(true);

        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;

        PauseCanva.SetActive(false);
        MyTestCanva.SetActive(true);
    }

    public void Retry()
    {
        Time.timeScale = 1;

        Touch.is_illustrate = true;
        Jump.answer = 1;
        Jump.Index = 1;
        ScoreBar.Score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Leave()
    {
        Time.timeScale = 1;

        Jump.answer = 1;
        Jump.Index = 1;
        Touch.is_illustrate = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        GManager.instance.Start = false;

        SceneManager.LoadScene("Section Menu");
    }
}
