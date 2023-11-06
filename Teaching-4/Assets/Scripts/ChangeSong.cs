using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeSong : MonoBehaviour
{
    [SerializeField] private NotesManager notesManager;
    //public string songName;

    public void OnButtonClick()
    {
        //notesManager.SetSongName(songName);
        SceneSwitch("SampleScene"); 
    }

    public void SceneSwitch(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

