using UnityEngine;
using TMPro;

public class Highlyscore : MonoBehaviour
{
    public TMP_Text currentScoreText;
    public TMP_Text highScoreText;

    private int currentScore = 0;
    private int highScore = 0;
    private string highScoreKey = "HighScore"; // 存储历史最高分的键名
    private number_update numberupdate;
    private AudioSource audioSource;


    private void Awake()
    {
        audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }
    void Start()
    {
        // 在游戏开始时加载历史最高分
        LoadHighScore();
        UpdateUI();
        audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
        currentScore = numberupdate.number;
    }

    void Update()
    {
        if (audioSource.isPlaying)
        {
        // 检查是否达到新的历史最高分
        if (currentScore > highScore)
        {
            highScore = currentScore;
            SaveHighScore(); // 如果是新的历史最高分，保存它
        }
        }
    }

    void UpdateUI()
    {
        // 更新 UI 文本显示
        highScoreText.text = highScore.ToString();

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

