using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeLeader : MonoBehaviour {

    private CSVReader csvReader = new CSVReader();
    private Dictionary<string, int> point = new Dictionary<string, int>();
    public number_update numberUpdate;
    public List<List<string>> MAP = new List<List<string>>();
    // Use this for initialization
    void Awake () {
        MAP = csvReader.readCSV("song.csv");
    }

    private void Start()
    {
        point.Add("perfect", int.Parse(MAP[0][1]));
        point.Add("good", int.Parse(MAP[0][2]));
    }

    public void ScoreUp(string position)
    {
        try
        {
            if(position == "perfect")
            {
                numberUpdate.number += 100 ;
            }
            if(position == "good")
            {
                numberUpdate.number += 50;    
            }
            
        }
        catch (System.Exception e)
        {

        }
    }
}
