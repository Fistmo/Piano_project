using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Touch : MonoBehaviour
{
    public int illustrate = 1;
    public static bool is_illustrate = true;
    public Text first;
    public Text second;
    public Text third;
    public Text fourth;
    public Text fifth;
    public GameObject illustrateCanvas;

    public static bool start = false;

    void Update()
    {


        if (is_illustrate == true)
        {
            if ((Input.touches.Length > 0) && (Input.touches[0].phase == TouchPhase.Ended) && (Input.touches[0].phase != TouchPhase.Canceled))
            {

                switch (illustrate)
                {
                    case 1:
                        first.gameObject.SetActive(false);
                        second.gameObject.SetActive(true);
                        illustrate = 2;
                        break;
                    case 2:
                        second.gameObject.SetActive(false);
                        third.gameObject.SetActive(true);
                        illustrate = 3;
                        break;
                    case 3:
                        third.gameObject.SetActive(false);
                        fourth.gameObject.SetActive(true);
                        illustrate = 4;
                        break;
                    case 4:
                        fourth.gameObject.SetActive(false);
                        fifth.gameObject.SetActive(true);
                        illustrate = 5;
                        break;
                    case 5:
                        fifth.gameObject.SetActive(false);


                        is_illustrate = false;
                        Debug.Log("End illustrate");

                        GManager.instance.Start = true;
                        Debug.Log("Start " + GManager.instance.Start);

                        illustrateCanvas.SetActive(false);
                        break;
                }
            }
        }
    }
}
