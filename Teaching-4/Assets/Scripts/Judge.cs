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
            if (notesManager.NotesTime.Count > 0 )
            {
                if (KBinput == 1) 
                {
                    audio.PlayOneShot(C4);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 0) 
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)), 0);
                    }
                }

                if (KBinput == 2)
                {
                    audio.PlayOneShot(CS4);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 0.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);
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

                if (KBinput == 4)
                {
                    audio.PlayOneShot(DS4);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 1.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 5)
                {
                    audio.PlayOneShot(E4);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 2)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
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

                if (KBinput == 7)
                {
                    audio.PlayOneShot(FS4);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 3.5)
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
                
                if (KBinput == 9)
                {
                    audio.PlayOneShot(GS4);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 4.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 10)
                {
                    audio.PlayOneShot(A4);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 11)
                {
                    audio.PlayOneShot(Bb4);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 5.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 12)
                {
                    audio.PlayOneShot(B4);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 6)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 13)
                {
                    audio.PlayOneShot(C5);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 7)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 14)
                {
                    audio.PlayOneShot(CS5);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 7.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 15)
                {
                    audio.PlayOneShot(D5);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 8)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 16)
                {
                    audio.PlayOneShot(DS5);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 8.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 17)
                {
                    audio.PlayOneShot(E5);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 9)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 18)
                {
                    audio.PlayOneShot(F5);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 10)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 19)
                {
                    audio.PlayOneShot(FS5);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 10.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 20)
                {
                    audio.PlayOneShot(G5);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 11)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 21)
                {
                    audio.PlayOneShot(GS5);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 11.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 22)
                {
                    audio.PlayOneShot(A5);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 12)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 23)
                {
                    audio.PlayOneShot(Bb5);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 12.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 24)
                {
                    audio.PlayOneShot(B5);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 13)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 25)
                {
                    audio.PlayOneShot(C6);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 14)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 26)
                {
                    audio.PlayOneShot(CS6);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 14.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 27)
                {
                    audio.PlayOneShot(D6);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 15)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 28)
                {
                    audio.PlayOneShot(DS6);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 15.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 29)
                {
                    audio.PlayOneShot(E6);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 16)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }
                
                if (KBinput == 30)
                {
                    audio.PlayOneShot(F6);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 17)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }   

                if (KBinput == 31)
                {
                    audio.PlayOneShot(FS6);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 17.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 32)
                {
                    audio.PlayOneShot(G6);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 18)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 33)
                {
                    audio.PlayOneShot(GS6);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 18.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 34)
                {
                    audio.PlayOneShot(A6);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 19)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 35)
                {
                    audio.PlayOneShot(Bb6);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 19.5)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 36)
                {
                    audio.PlayOneShot(B6);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 20)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

                if (KBinput == 37)
                {
                    audio.PlayOneShot(C7);
                    KBinput = 0;
                    if (notesManager.LaneNum[0] == 21)
                    {
                        Judgement(GetABS(Time.time - (notesManager.NotesTime[0] + GManager.instance.StartTime)),0);//
                    }
                }

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
        if (timeLag <= 0.2)//如果音符應該被敲擊的時間和音符被實際敲擊的時間相差0.2秒或更小
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
            if (timeLag <= 0.3)//如果你應該擊中音符的時間和你實際擊中音符的時間差小於0.3秒
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
                if (timeLag <= 0.4)///如果你應該擊中音符的時間與你實際擊中音符的時間之間的差異小於 0.4 秒
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