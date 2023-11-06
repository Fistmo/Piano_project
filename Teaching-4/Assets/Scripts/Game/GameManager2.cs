using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public static bool IsGamePaused = false;

    // 游戏中的菜单
    public GameObject ingameMenu;


    public void OnPause()
    {
        Time.timeScale = 0;
        ingameMenu.SetActive(true);
        IsGamePaused = true;
    }

    public void OnResume()
    {
        Time.timeScale = 1f;
        ingameMenu.SetActive(false);
        IsGamePaused = false;
    }

    public void Setting()
    {
        // 加载场景
        SceneManager.LoadScene("Section Menu");
        Time.timeScale = 1f;
        ingameMenu.SetActive(false);
        IsGamePaused = false;
    }
    public void OnAgain()
    {
        // 加载场景
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        Time.timeScale = 1f;
        ingameMenu.SetActive(false);
        IsGamePaused = false;
    }
}
