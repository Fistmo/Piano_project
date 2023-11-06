using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MAP : MonoBehaviour
{
    private CSVWriter csvWriter = new CSVWriter();
    private List<List<string>> csv = new List<List<string>>();
    int a = 0;
    int s = 0;
    int d = 0;
    float currentTime = 0; // 声明并初始化 currentTime 变量

    void LateUpdate()
    {
        currentTime += Time.deltaTime; // 使用 currentTime
        if (a + s + d != 0)
        {
            List<string> line = new List<string>();
            line.Add(currentTime.ToString());
            line.Add(a.ToString());
            line.Add(s.ToString());
            line.Add(d.ToString());
            csv.Add(line);
            a = s = d = 0;
        }
        if (Input.anyKey)
        {
            if (Input.GetKeyDown("a"))
            {
                a = 1;
            }
            if (Input.GetKeyDown("s"))
            {
                s = 1;
            }
            if (Input.GetKeyDown("d"))
            {
                d = 1;
            }
        }
    }

    private void OnApplicationQuit()
    {
        csvWriter.WriteCSV(csv, "song.csv");
    }
}
