using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
        [SerializeField] GameObject HomeMenu;
        public void Home()
        {
            HomeMenu.SetActive(true);
            Time.timeScale = 0;
        }
        public void goout()
        {
            //SceneManager.LoadScene("SampleScene");
            HomeMenu.SetActive(false);
            Time.timeScale = 1;
        }
        public void retry()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
        public void gohome()
        {
            SceneManager.LoadScene("Section Menu");
            Time.timeScale = 1;
        }
        

}
