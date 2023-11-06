using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timingGeter : MonoBehaviour
{
    const string nodeName = "Node(Clone)";
    public GameObject tapPosition;
    public checkTiming checktiming;

    private void Start()
    {
        checktiming = tapPosition.GetComponent<checkTiming>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == nodeName)
        {
            checktiming.Timing[this.gameObject.name].
                Add(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == nodeName)
        {
            checktiming.Timing[this.gameObject.name].Remove(other.gameObject);
        }
    }
}
