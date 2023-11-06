using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    //ノーツのスピードを設定
    int NoteSpeed = 8;
    bool start;
    void Update()
    {
        if ((Input.touches.Length > 0) && (Input.touches[0].phase == TouchPhase.Ended) && (Input.touches[0].phase != TouchPhase.Canceled))
        {
            start = true;
        }
        if (start)
        {
            transform.position -= transform.forward * Time.deltaTime * NoteSpeed;
        }
    }
}