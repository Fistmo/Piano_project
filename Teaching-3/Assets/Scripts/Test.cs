using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public RawImage C_R; 
    public RawImage D_R;
    public RawImage E_R;
    public RawImage F_R;
    public RawImage G_R;
    public RawImage A_R;
    public RawImage B_R;

    public GameObject EndCanvas;
    public GameObject RandomCanvas;
    public GameObject EnterCanvas;
    public GameObject MyTestCanvas;

    public int randomNumber;
    public int[] testArray = new int[3];
    public int test_times = 0;

    public static int KBinput = 0;
    public int enter_times = 0;

    int index = 0;

    void Start()
    {
        generateNote();
    }

    void Update()
    {
        CheckAnswer();
    }

    void generateNote()
    {
        randomNumber = Random.Range(1, 8);
        testArray[0] = randomNumber;
        do
        {
            randomNumber = Random.Range(1, 8);
            testArray[1] = randomNumber;
        } while (testArray[1] == testArray[0]);
        do
        {
            randomNumber = Random.Range(1, 8);
            testArray[2] = randomNumber;
        } while (testArray[2] == testArray[0] || testArray[2] == testArray[1]);
       
        float x_position = -350;

        for (int i = 0; i < 3; i++)
        {
            Debug.Log("yes");
            switch (testArray[i])
            {
                case 1:
                    C_R.gameObject.SetActive(true);

                    RectTransform rectTransform_C = C_R.GetComponent<RectTransform>();
                    rectTransform_C.anchoredPosition = new Vector2(x_position, rectTransform_C.anchoredPosition.y);

                    break;
                case 2:
                    D_R.gameObject.SetActive(true);

                    RectTransform rectTransform_D = D_R.GetComponent<RectTransform>();
                    rectTransform_D.anchoredPosition = new Vector2(x_position, rectTransform_D.anchoredPosition.y);

                    break;
                case 3:
                    E_R.gameObject.SetActive(true);

                    RectTransform rectTransform_E = E_R.GetComponent<RectTransform>();
                    rectTransform_E.anchoredPosition = new Vector2(x_position, rectTransform_E.anchoredPosition.y);

                    break;
                case 4:
                    F_R.gameObject.SetActive(true);

                    RectTransform rectTransform_F = F_R.GetComponent<RectTransform>();
                    rectTransform_F.anchoredPosition = new Vector2(x_position, rectTransform_F.anchoredPosition.y);

                    break;
                case 5:
                    G_R.gameObject.SetActive(true);

                    RectTransform rectTransform_G = G_R.GetComponent<RectTransform>();
                    rectTransform_G.anchoredPosition = new Vector2(x_position, rectTransform_G.anchoredPosition.y);
                   

                    break;
                case 6:
                    A_R.gameObject.SetActive(true);

                    RectTransform rectTransform_A = A_R.GetComponent<RectTransform>();
                    rectTransform_A.anchoredPosition = new Vector2(x_position, rectTransform_A.anchoredPosition.y);

                    break;
                case 7:
                    B_R.gameObject.SetActive(true);

                    RectTransform rectTransform_B = B_R.GetComponent<RectTransform>();
                    rectTransform_B.anchoredPosition = new Vector2(x_position, rectTransform_B.anchoredPosition.y);

                    break;
            }
            x_position = x_position + 350;
        }
        test_times += 1;

        Timer.time_start = Time.time;
        Timer.is_timer_start = true;

    }

    void CheckAnswer()
    {

        if (KBinput != 0)
        {
            enter_times += 1;
            switch (testArray[index])
            {
                case 1:
                    if (KBinput == 1)
                    {
                        ScoreBar.Score += 100;
                        index += 1;
                        C_R.gameObject.SetActive(false);
                    }
                    break;
                case 2:
                    if (KBinput == 3)
                    {
                        ScoreBar.Score += 100;
                        index += 1;
                        D_R.gameObject.SetActive(false);
                    }
                    break;
                case 3:
                    if (KBinput == 5)
                    {
                        ScoreBar.Score += 100;
                        index += 1;
                        E_R.gameObject.SetActive(false);
                    }
                    break;
                case 4:
                    if (KBinput == 6)
                    {
                        ScoreBar.Score += 100;
                        index += 1;
                        F_R.gameObject.SetActive(false);
                    }
                    break;
                case 5:
                    if (KBinput == 8)
                    {
                        ScoreBar.Score += 100;
                        index += 1;
                        G_R.gameObject.SetActive(false);
                    }
                    break;
                case 6:
                    if (KBinput == 10)
                    {
                        ScoreBar.Score += 100;
                        index += 1;
                        A_R.gameObject.SetActive(false);
                    }
                    break;
                case 7:
                    if (KBinput == 12)
                    {
                        ScoreBar.Score += 100;
                        index += 1;
                        B_R.gameObject.SetActive(false);
                    }
                    break;
            }
            KBinput = 0;
        }

        //if ((Input.touches.Length > 0) && (Input.touches[0].phase == TouchPhase.Ended) && (Input.touches[0].phase != TouchPhase.Canceled))
        //{
        //    Debug.Log("index" + index);
        //    switch (testArray[index])
        //    {
        //        case 1:
        //            ScoreBar.Score += 100;
        //            //index += 1;
        //            C_R.gameObject.SetActive(false);
        //            break;
        //        case 2:
        //            ScoreBar.Score += 100;
        //            //index += 1;
        //            D_R.gameObject.SetActive(false);
        //            break;
        //        case 3:
        //            ScoreBar.Score += 100;
        //            //index += 1;
        //            E_R.gameObject.SetActive(false);
        //            break;
        //        case 4:
        //            ScoreBar.Score += 100;
        //            //index += 1;
        //            F_R.gameObject.SetActive(false);
        //            break;
        //        case 5:
        //            ScoreBar.Score += 100;
        //            //index += 1;
        //            G_R.gameObject.SetActive(false);
        //            break;
        //        case 6:
        //            ScoreBar.Score += 100;
        //            //index += 1;
        //            A_R.gameObject.SetActive(false);
        //            break;
        //        case 7:
        //            ScoreBar.Score += 100;
        //            //index += 1;
        //            B_R.gameObject.SetActive(false);
        //            break;
        //    }
        //    index += 1;
        //}


        if (index == 3 || Timer.is_timer_end == true)
        {
            if (test_times == 3)
            {
                close_All();
                EndCanvas.SetActive(true);
            }
            else
            {
                C_R.gameObject.SetActive(false);
                D_R.gameObject.SetActive(false);
                E_R.gameObject.SetActive(false);
                F_R.gameObject.SetActive(false);
                G_R.gameObject.SetActive(false);
                A_R.gameObject.SetActive(false);
                B_R.gameObject.SetActive(false);
                generateNote();
                index = 0;
            }
        }
    }

    void close_All()
    {
        RandomCanvas.SetActive(false);
        EnterCanvas.SetActive(false);
        MyTestCanvas.SetActive(false);
        GManager.instance.Start = false;
    }

}
