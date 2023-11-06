using System;
using UnityEngine;
using TMPro;
public class Judge : MonoBehaviour
{
    public static int KBinput = 0;

    //変数の宣言
    [SerializeField] private GameObject[] MessageObj;// 將決定傳達給玩家的遊戲對象
    [SerializeField] NotesManager notesManager;//變量來放置腳本“notesManager”

    [SerializeField] TextMeshProUGUI comboText;
    [SerializeField] TextMeshProUGUI scoreText;

    AudioSource audio;
    //[SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip C4;
    [SerializeField] AudioClip D4;
    [SerializeField] AudioClip E4;
    [SerializeField] AudioClip F4;
    [SerializeField] AudioClip G4;
    [SerializeField] AudioClip A4;
    [SerializeField] AudioClip B4;
    [SerializeField] AudioClip CS4;
    [SerializeField] AudioClip DS4;
    [SerializeField] AudioClip FS4;
    [SerializeField] AudioClip GS4;
    [SerializeField] AudioClip Bb4;

    [SerializeField] AudioClip C5;
    [SerializeField] AudioClip D5;
    [SerializeField] AudioClip E5;
    [SerializeField] AudioClip F5;
    [SerializeField] AudioClip G5;
    [SerializeField] AudioClip A5;
    [SerializeField] AudioClip B5;
    [SerializeField] AudioClip CS5;
    [SerializeField] AudioClip DS5;
    [SerializeField] AudioClip FS5;
    [SerializeField] AudioClip GS5;
    [SerializeField] AudioClip Bb5;

    [SerializeField] AudioClip C6;
    [SerializeField] AudioClip D6;
    [SerializeField] AudioClip E6;
    [SerializeField] AudioClip F6;
    [SerializeField] AudioClip G6;
    [SerializeField] AudioClip A6;
    [SerializeField] AudioClip B6;
    [SerializeField] AudioClip CS6;
    [SerializeField] AudioClip DS6;
    [SerializeField] AudioClip FS6;
    [SerializeField] AudioClip GS6;
    [SerializeField] AudioClip Bb6;
    [SerializeField] AudioClip C7;


    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (GManager.instance.Start)
        {
            
            //Debug.Log("NotesTime.Count: " +notesManager.NotesTime.Count);
            //Debug.Log("notesManager.LaneNum[0]:"+notesManager.LaneNum[0]);
            //Debug.Log("Time:"+(notesManager.NotesTime[1]-notesManager.NotesTime[0]));
            //Debug.Log("Time.time:"+Time.time);
            //Debug.Log("GManager.instance.StartTime:"+GManager.instance.StartTime);
            if (notesManager.NotesTime.Count > 0 )
            {
                //Debug.Log("["+notesManager.NotesTime.Count+"]T:"+Time.time+" N:"+notesManager.NotesTime[0]+" G:"+GManager.instance.StartTime+ " diff"+(Time.time-GManager.instance.StartTime));
                if (KBinput == 1) //當A鍵被按下時
                {
                    audio.PlayOneShot(C4);

                    KBinput = 0;

                    //Debug.Log("@T:"+Time.time+" N:"+notesManager.NotesTime[0]+" G:"+GManager.instance.StartTime);
                    if (notesManager.LaneNum[0] == 0) //按下的按鈕是否與車道號匹配？
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)), 0);

            //Time.time：自遊戲開始以來的當前遊戲時間（以秒為單位），隨著遊戲的運行不斷增加。
            //NotesManager.NotesTime[0]：這代表應演奏第一個音符的時間（以秒為單位）。從NotesManager.cs的NotesTime列表中獲取，[0]是指訪問列表中的第一個元素。
            //GManager.instance.StartTime：遊戲開始時間的參考，即按下空白鍵的那個時間，是一個定值，計算的參考點。
                    }
                
                }

                if (KBinput == 3)
                {
                    audio.PlayOneShot(D4);

                    KBinput = 0;

                    if (notesManager.LaneNum[0] == 1)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);
                    }
                }

                if (KBinput == 5)
                {
                    audio.PlayOneShot(E4);

                    KBinput = 0;

                    if (notesManager.LaneNum[0] == 2)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);
                    }
                }

                if (KBinput == 6)
                {
                    audio.PlayOneShot(F4);

                    KBinput = 0;

                    if (notesManager.LaneNum[0] == 3)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 8)
                {
                    audio.PlayOneShot(G4);

                    KBinput = 0;

                    if (notesManager.LaneNum[0] == 4)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 10)
                {
                    audio.PlayOneShot(A5);

                    KBinput = 0;

                    if (notesManager.LaneNum[0] == 5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }

                }
                if (KBinput == 12)
                {
                    audio.PlayOneShot(B5);

                    KBinput = 0;

                    if (notesManager.LaneNum[0] == 6)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                //if (Input.GetButtonDown("K"))
                //{
                //    audio.PlayOneShot(C5);
                //    if (notesManager.LaneNum[0] == 7)
                //    {
                //        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                //    }

                //}
                //if (Input.GetButtonDown("L"))
                //{
                //    audio.PlayOneShot(D5);
                //    if (notesManager.LaneNum[0] == 8)
                //    {
                //        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                //    }
                //}

                //if (Input.GetButtonDown("T"))
                //{
                //    audio.PlayOneShot(FS4);
                //    if (notesManager.LaneNum[0] == 3.5)
                //    {
                //        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                //    }
                //}
            }

            if (notesManager.NotesTime.Count > 0)
            {
                if (Time.time > notesManager.NotesTime[0] + 0.4f +GManager.instance.StartTime)//如果在應該敲擊音符的時間後 0.2 秒後仍然沒有輸入
                //if (GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime))>  0.4f )
                {
                    message(3);
                    deleteData(0);
                    Debug.Log("Miss");
                    //Debug.Log("Miss"+"["+notesManager.NotesTime.Count+"]T:"+Time.time+" N:"+notesManager.NotesTime[0]+" G:"+GManager.instance.StartTime);
                    GManager.instance.miss++;
                    GManager.instance.combo = 0;
                }
            }

        }
    }
    void Judgement(float timeLag,int numOffset)
    {
        //Debug.Log("timeLag:" +timeLag+" numOffset:" +numOffset);
        //audio.PlayOneShot(hitSound);
        if (timeLag <= 0.2)//如果音符應該被敲擊的時間和音符被實際敲擊的時間相差0.05秒或更小
        {
            Debug.Log("Perfect"+" timeLag:" +timeLag);
            message(0);
            GManager.instance.score += 100;
            GManager.instance.perfect++;
            GManager.instance.combo++;
            deleteData(numOffset);
        }
        else
        {
            if (timeLag <= 0.3)//如果你應該擊中音符的時間和你實際擊中音符的時間差小於0.08秒
            {
                Debug.Log("Great"+" timeLag:" +timeLag);
                message(1);
                GManager.instance.score += 80;
                GManager.instance.great++;
                GManager.instance.combo++;
                deleteData(numOffset);
            }
            else
            {
                if (timeLag <= 0.4)///如果你應該擊中音符的時間與你實際擊中音符的時間之間的差異小於 0.10 秒
                {
                    Debug.Log("Bad"+" timeLag:" +timeLag);
                    message(2);
                    GManager.instance.score += 10;
                    GManager.instance.bad++;
                    GManager.instance.combo = 0;
                    deleteData(numOffset);
                }
                else
                {
                Debug.Log("Over Time"+" timeLag:" +timeLag);
                deleteData(numOffset);
                }
            }
        }
        
    }
    float GetABS(float num)// 返回參數絕對值的函數
    {
        if (num >= 0)
        {
            return num;
        }
        else
        {
            return -num;
        }
    }
    void deleteData(int numOffset)// 刪除已經敲擊的音符的函數
    {
        notesManager.NotesTime.RemoveAt(numOffset);
        notesManager.LaneNum.RemoveAt(numOffset);
        notesManager.NoteType.RemoveAt(numOffset);
        
        comboText.text = GManager.instance.combo.ToString();
        scoreText.text = GManager.instance.score.ToString();
    }

    void message(int judge)// 顯示判斷
    {
        Instantiate(MessageObj[judge],new Vector3(notesManager.LaneNum[0]-8.5f,0.76f,0.15f),Quaternion.Euler(45,0,0));
    }


}