using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class number_update : MonoBehaviour {

    public int number = 0;
    private int localNumber = 0;
    private int def = 0;
    private int defCheckUpdate = 0;
    private float onceUpdateNumber = 0;
    public float uplong = 0.5f;

    public string after_adder;
    public string befor_adder;
    public TMP_Text Score;
    public TMP_Text Score_end;
    public TMP_Text highScoreText;
    public TMP_Text criteria;
    public TMP_Text Accuracy;
    private int currentScore = 0;
    private int highScore = 0;
    private string highScoreKey = "HighScore";
    private enum Mode
    {
        func_update = 0,
        num_update,
    }
    [SerializeField]
    private Mode mode = Mode.num_update;

    private float t=0f;
    

	// Use this for initialization
	void Start ()
    {
        localNumber = number;
        Score.text = befor_adder + localNumber + after_adder;
        Score_end.text = localNumber.ToString();
        LoadHighScore();
    }

    /// <summary>
    /// Mode が func_updateの場合この関数が呼び出されるまで数値の変動が起きない
    /// </summary>
    public void NumUpdate()
    {
        NumDefFunc();
        if (number != (int)Mathf.Floor(onceUpdateNumber))
        {
            onceUpdateNumber += (def * Time.deltaTime / uplong);
            localNumber = ((int)Mathf.Floor(onceUpdateNumber));
            Score.text = befor_adder + localNumber+ after_adder;
            Score_end.text = localNumber.ToString();
            highScoreText.text = highScore.ToString();
            if(2950 <localNumber && localNumber < 5310)
            {
                criteria.text = "Good";
                Accuracy.text = "Over 50% Good";
            }
            else if( localNumber >= 5310)
            {
                criteria.text = "PERFECT";
                Accuracy.text = "Over 90% Perfect";
            }
            else{
                criteria.text = "Bad";
                Accuracy.text = "lower 50% Good";
            }


        }
        else
        {
            t = 0f;
        }
    }

    private void NumDefFunc()
    {
        def = number - localNumber;
    }

    private void debugLogs()
    {
        t += Time.deltaTime;
        Debug.Log("Up " + onceUpdateNumber + " /Lo " + (float)localNumber + " /De " + (float)def+" /Td "+defCheckUpdate+" /num "+ number + " /time "+t);
    }

    private void SelectMode()
    {
        switch (mode)
        {
            case Mode.func_update:

                break;
            case Mode.num_update:
                NumUpdate();
                break;
            default:
                break;
        }
    }

	// Update is called once per frame
	void Update ()
    {
        if (number != localNumber)
        {
            SelectMode();
        }
        currentScore = localNumber;
        if (currentScore > highScore)
        {
            highScore = currentScore;
            SaveHighScore(); // 如果是新的历史最高分，保存它
        }
    }
    
    void SaveHighScore()
    {
        // 保存历史最高分到 PlayerPrefs
        PlayerPrefs.SetInt(highScoreKey, highScore);
        PlayerPrefs.Save(); // 保存修改
    }

    void LoadHighScore()
    {
        // 从 PlayerPrefs 中加载历史最高分
        if (PlayerPrefs.HasKey(highScoreKey))
        {
            highScore = PlayerPrefs.GetInt(highScoreKey);
        }
    }
}
