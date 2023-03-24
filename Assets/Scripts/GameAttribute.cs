using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAttribute : MonoBehaviour
{
    // Start is called before the first frame update
    [MyTestAttribute(0,100)]
    public int value = 0;

#if UNITY_EDITOR
    private void OnValidate()
    {
        Debug.Log("脚本对象数据发生改变事件");
    }
#endif
}
