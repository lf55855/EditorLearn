using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(UnityEditor.SceneAsset))]
public class CustomAssetInspector : Editor
{
    public override void OnInspectorGUI()
    {
        string path = AssetDatabase.GetAssetPath(target);
        Debug.Log(path);
        GUI.enabled = true;
        if (path.EndsWith(".unity"))
        {
            GUILayout.Button("���ǳ���");

        }
        else if (path.EndsWith(""))
        {

            GUILayout.Button("�����ļ���");
        }
    }
}
