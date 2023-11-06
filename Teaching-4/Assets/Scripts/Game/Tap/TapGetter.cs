using UnityEngine;
using System.Collections.Generic;

public class TapGetter : MonoBehaviour
{
    public static int KBinput = 0;
    public Dictionary<GameObject, TouchPhase> OnTouchPhase()
    {
        Dictionary<GameObject, TouchPhase> ret = new Dictionary<GameObject, TouchPhase>();

        // 检测键盘输入，例如使用键盘上的A、S、D键
        if (KBinput == 1 )
        {
            // 创建一个虚拟的 TouchPhase.Began 事件，并将其关联到一个游戏对象
            ret.Add(GameObject.Find("TapObject"), TouchPhase.Began);
            KBinput = 0;
        }

        if (KBinput == 2 )
        {
            // 创建一个虚拟的 TouchPhase.Moved 事件，并将其关联到一个游戏对象
            ret.Add(GameObject.Find("TapObject 2"), TouchPhase.Began);
            KBinput = 0;
        }

        if (KBinput == 3 )
        {
            // 创建一个虚拟的 TouchPhase.Ended 事件，并将其关联到一个游戏对象
            ret.Add(GameObject.Find("TapObject 3"), TouchPhase.Ended);
            KBinput = 0;
        }

        return ret;
    }
}