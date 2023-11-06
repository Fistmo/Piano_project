using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapHome : MonoBehaviour {
    private TapGetter tapGetter;
    public Dictionary<GameObject, checkTiming> toCheckTiming = new Dictionary<GameObject, checkTiming>();
    private void Awake()
    {
        tapGetter = GetComponent<TapGetter>();
    }

    private void Start()
    {
        GameObject.Find("NodeLine 1");
        GameObject.Find("NodeLine 1/TapPosition").GetComponent<checkTiming>();
        toCheckTiming.Add(GameObject.Find("NodeLine 1"), GameObject.Find("NodeLine 1/TapPosition").GetComponent<checkTiming>());
        toCheckTiming.Add(GameObject.Find("NodeLine 2"), GameObject.Find("NodeLine 2/TapPosition").GetComponent<checkTiming>());
        toCheckTiming.Add(GameObject.Find("NodeLine 3"), GameObject.Find("NodeLine 3/TapPosition").GetComponent<checkTiming>());
    }

    private void Update()
    {
        Dictionary<GameObject, TouchPhase> tapinfo = tapGetter.OnTouchPhase();
        foreach(var key in tapinfo.Keys)
        {
            if(key.name == "TapObject")
            {
                var line = key.transform.parent.gameObject;
                toCheckTiming[line].Tap();
            }

            if(key.name == "TapObject 2")
            {
                var line = key.transform.parent.gameObject;
                toCheckTiming[line].Tap();
            }

            if(key.name == "TapObject 3")
            {
                var line = key.transform.parent.gameObject;
                toCheckTiming[line].Tap();
            }
        }
    }

}
