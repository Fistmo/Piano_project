using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{
    public RawImage C1; // 你的 RawImage 元件
    public RawImage D1;
    public RawImage E1;
    public RawImage F1;
    public RawImage G1;
    public RawImage A1;
    public RawImage B1;

    public GameObject RandomCanvas;

    public int Index = 0;
    public RawImage rawImage;

    public float jumpHeight = 10f; // 跳躍高度
    public float jumpSpeed = 10f; // 跳躍速度
    private bool isJumping = false; // 是否已經跳動過一次

    private float initialY; // 初始 Y 坐標

    public static int KBinput = 0;
    public int answer = 0;
    public bool isCorrect = false;

    private void Start()
    {
        initialY = C1.rectTransform.anchoredPosition.y; // 記錄初始 Y 坐標
        rawImage = C1;
    }

    private void Update()
    {

        CheckAnswer();

        if (Touch.is_illustrate == true)
        {
            isJumping = false;
        }
        if (!isJumping)
        {
            if (isCorrect) // 或者其他你想要的觸發條件
            {
                isJumping = true; // 開始跳動
            }
        }
        else
        {
            // 使用 Sin 函數來實現上下跳躍效果
            float yOffset = Mathf.Sin(Time.time * jumpSpeed) * jumpHeight;

            // 更新 RawImage 的 Y 坐標
            Vector2 newPos = new Vector2(rawImage.rectTransform.anchoredPosition.x, initialY + yOffset);
            rawImage.rectTransform.anchoredPosition = newPos;
            Debug.Log(rawImage.rectTransform.anchoredPosition);

            if (Mathf.Abs(yOffset) < 1f) // 跳動高度接近零
            {
                isJumping = false; // 停止跳動
                Change_Note();
                isCorrect = false;
                Debug.Log("stop");
            }
        }
    }

    private void Change_Note()
    {
        switch (Index)
        {
            case 1:
                initialY = C1.rectTransform.anchoredPosition.y;
                rawImage = C1;

                answer = 1;

                Index = 2;
                break;
            case 2:
                C1.gameObject.SetActive(false);
                D1.gameObject.SetActive(true);
                initialY = D1.rectTransform.anchoredPosition.y; 
                rawImage = D1;

                answer = 3;

                Index = 3;
                break;
            case 3:
                D1.gameObject.SetActive(false);
                E1.gameObject.SetActive(true);
                initialY = E1.rectTransform.anchoredPosition.y;
                rawImage = E1;

                answer = 5;

                Index = 4;
                break;
            case 4:
                E1.gameObject.SetActive(false);
                F1.gameObject.SetActive(true);
                initialY = F1.rectTransform.anchoredPosition.y;
                rawImage = F1;

                answer = 6;

                Index = 5;
                break;
            case 5:
                F1.gameObject.SetActive(false);
                G1.gameObject.SetActive(true);
                initialY = G1.rectTransform.anchoredPosition.y;
                rawImage = G1;

                answer = 8;

                Index = 6;
                break;
            case 6:
                G1.gameObject.SetActive(false);
                A1.gameObject.SetActive(true);
                initialY = A1.rectTransform.anchoredPosition.y;
                rawImage = A1;

                answer = 10;

                Index = 7;
                break;
            case 7:
                A1.gameObject.SetActive(false);
                B1.gameObject.SetActive(true);
                initialY = B1.rectTransform.anchoredPosition.y;
                rawImage = B1;

                answer = 12;

                Index = 8;
                break;
            case 8:
                B1.gameObject.SetActive(false);

                RandomCanvas.SetActive(true);
                break;
        }
    }

    private void CheckAnswer()
    {
        if (KBinput == answer)
        {
            isCorrect = true;
        }
        else
        {
            isCorrect = false;
        }
    }

}