using UnityEngine;
using System.Collections.Generic;
using TMPro;


public class NodeCreater : MonoBehaviour {
    private List<List<string>> MAP = new List<List<string>>();
    private float time;
    public GameObject Node;
    private GameObject nodeParent;
    private GameObject lostPosition;
    private GameObject destination;
    public GameObject gameResultScreen;
    private bool gameResultScreenShown = false;
    private bool musicEnded = false;
    private float musicEndTime = 0f;
    private float timeSinceMusicEnded = 0f;
    private int Line = 1;
    public int Selector = 0;
    private AudioSource audioSource;
    private bool canStart = false;
    public TMP_Text Score;
    public GameObject Intro;
    public GameObject Pause;

    
    private void Awake()
    {
        nodeParent = gameObject.transform.parent.gameObject;
        destination = GameObject.Find(nodeParent.name + "/TapPosition");
        lostPosition = GameObject.Find(nodeParent.name + "/lostPosition");
        Selector = int.Parse(nodeParent.name.Replace("NodeLine",""));
        audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    }

    private void Start()
{
    MAP = GameObject.Find("Feeld").GetComponent<NodeLeader>().MAP;
    audioSource = GameObject.Find("Main Camera").GetComponent<AudioSource>();
    audioSource.enabled = false; // 禁用音频源
}



    private void Update()
{
   if ((Input.touches.Length > 0 && Input.touches[0].phase == TouchPhase.Ended) || Input.GetKeyDown(KeyCode.Space))
    {
        Intro.gameObject.SetActive(false);
        canStart = true; // Set to allow the code execution to begin
    }


    if (canStart)
    {
    time += Time.deltaTime;
    if (audioSource.isPlaying)
            {
                // Music has ended
                musicEnded = true;
                musicEndTime = time;
            }

            if (musicEnded)
            {
                // Wait for 3 seconds after music has ended
                timeSinceMusicEnded = time - musicEndTime;

                if (timeSinceMusicEnded >= 4f && !gameResultScreenShown)
                {
                    // After 3 seconds, show the game result screen
                    ShowGameResultScreen();
                    Score.gameObject.SetActive(false);
                    Pause.gameObject.SetActive(false);
                }
            }
    try
    {
        if (time >= float.Parse(MAP[Line][0]))
        {
            if (int.Parse(MAP[Line][Selector]) == 1)
            {
                NodeCreate();
            }
            Line++;
        }
        if (time <= 3f)
        {
            audioSource.enabled = true; // 启用音频源
            audioSource.Play();
            
        }

        if(GameManager2.IsGamePaused)
        {
            audioSource.Pause();
        }
        else
        {
            audioSource.UnPause();
        }
    }
    catch (System.ArgumentOutOfRangeException e)
    {
        //TODO 曲の状態を取得して、曲が終了していればリザルト画面へ遷移する。
    }
    
    }
}


    private void NodeCreate()
    {
        var node = (GameObject)Instantiate(Node,nodeParent.transform);
        node.GetComponent<NodeMove>().destination = destination;
        node.GetComponent<NodeMove>().lostPosition = lostPosition;
        node.transform.localPosition = this.transform.localPosition;
        node.transform.localRotation = this.transform.localRotation;
        node.transform.localScale = new Vector3(0.53114f, 0.008750159f, 0.061668f);
    }

    private void ShowGameResultScreen()
    {
        // 激活游戏结算画面的 GameObject
        gameResultScreen.SetActive(true);
        gameResultScreenShown = true; // 防止多次显示
    }
}
