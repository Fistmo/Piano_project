using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public bool CollisionOccurred { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("碰撞線1"))
        {
            Debug.Log("方塊通過碰撞區域");
            CollisionOccurred = true;
        }
    }
}
