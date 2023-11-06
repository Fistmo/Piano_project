using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
    
    /*void OnEnable()
    {
        noteNum = 0;
        songName = "大鐘";
        Load(songName);
    }*/

    void start()
    {
        SetSongNameToA();
    }

    public void SetSongNameToA()
    {
        songName = "大鐘";
        Load(songName);
    }

    public void SetSongNameToB()
    {
        songName = "火車快飛";
        Load(songName);
    }

    public void SetSongNameToC()
    {
        songName = "小叮噹";
        Load(songName);
    }
    public void SetSongNameToD()
    {
        songName = "隱形的翅膀";
        Load(songName);
    }
    public void SetSongNameToE()
    {
        songName = "靜夜星空";
        Load(songName);
    }
    public void SetSongNameToF()
    {
        songName = "森林狂想曲";
        Load(songName);
    }


    private void Load(string SongName)
    {
        
        string inputString = Resources.Load<TextAsset>(SongName).ToString();
        Data inputJson = JsonUtility.FromJson<Data>(inputString);

        noteNum = inputJson.notes.Length;

        Debug.Log("Number of notes: " + noteNum);

        for (int i = 0; i < inputJson.notes.Length; i++)
        {
            float kankaku = 60 / (inputJson.BPM * (float)inputJson.notes[i].LPB); 
            float beatSec = kankaku * (float)inputJson.notes[i].LPB; 
            float time = (beatSec * inputJson.notes[i].num / (float)inputJson.notes[i].LPB) + inputJson.offset + 0.01f; 
	    NotesTime.Add(time); 
            LaneNum.Add(inputJson.notes[i].block);
            NoteType.Add(inputJson.notes[i].type);
    
            float z = NotesTime[i] * NotesSpeed; 
            NotesObj.Add(Instantiate(noteObj, new Vector3(inputJson.notes[i].block - 8.5f, 0.55f, z), Quaternion.identity));
            
        }
    }


}