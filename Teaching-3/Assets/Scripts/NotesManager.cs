using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Data
{
    public string name;
    public int maxBlock;
    public int BPM;
    public int offset;
    public Note[] notes;

}
[Serializable]
public class Note
{
    public int type;
    public int num;
    public float block;
    public int LPB;
}

public class NotesManager : MonoBehaviour
{
    public int noteNum;
    private string songName;

    public List<float> LaneNum = new List<float>();
    public List<int> NoteType = new List<int>();
    public List<float> NotesTime = new List<float>();
    public List<GameObject> NotesObj = new List<GameObject>();

    [SerializeField] private float NotesSpeed;
    [SerializeField] GameObject noteObj;

    void OnEnable()
    {
        noteNum = 0;
        songName = "大鐘3";
        Load(songName);
    }

    private void Load(string SongName)
    {
        ClearNotesObjects(); // 清理舊的遊戲物體
        string inputString = Resources.Load<TextAsset>(SongName).ToString();
        Data inputJson = JsonUtility.FromJson<Data>(inputString);

        noteNum = inputJson.notes.Length;

        Debug.Log("Number of notes: " + noteNum);

        for (int i = 0; i < inputJson.notes.Length; i++)
        {
            float kankaku = 60 / (inputJson.BPM * (float)inputJson.notes[i].LPB); 
            //這是一個時間單位，表示每個音符之間的時間間隔。kankaku的計算是根據每分鐘拍數(BPM)和每拍的長度(LPB)來計算的
            float beatSec = kankaku * (float)inputJson.notes[i].LPB; 
            //beatSec表示每個節拍的長度（以秒為單位）。透過kankaku值乘以LPB來計算。代表單個節拍持續多長時間。
            float time = (beatSec * inputJson.notes[i].num / (float)inputJson.notes[i].LPB) + inputJson.offset + 0.01f; 
            //time變量表示當前音符應演奏的確切時間。根據節拍長度beatSec、音符位置(inputJson.notes[i].num)和偏移量(inputJson.offset)計算的。+0.01f確保音符不會放得太近。
            NotesTime.Add(time); 
            //將time變量的值添加到NotesTime列表中。time：是一個float，用於計算出特定音符應演奏的時間。因此NotesTime列表可以追蹤遊戲中所有音符的計時訊息。
            LaneNum.Add(inputJson.notes[i].block);
            NoteType.Add(inputJson.notes[i].type);
    
            float z = NotesTime[i] * NotesSpeed; //計算位置z，並且乘以NotesSpeed。然後使用Instantiate方法創建一個對話框對象(noteObj)，並放置在計算出來的位置上
            NotesObj.Add(Instantiate(noteObj, new Vector3(inputJson.notes[i].block - 8.5f, 0.55f, z), Quaternion.identity));
            
        }
    }

public void ChangeSong(string newSongName)
{
    songName = newSongName;
    Load(songName); // 重新載入新的歌曲資料
}


private void ClearNotesObjects()
{
    foreach (GameObject noteObj in NotesObj)
    {
        Destroy(noteObj);
    }
    NotesObj.Clear();
}

}