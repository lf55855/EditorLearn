using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(Sample))]
public class SampleEditor : Editor {
    public override void OnInspectorGUI() {
        Sample sample = (Sample) target;
        sample.bValue = EditorGUILayout.BoundsField("边界",sample.bValue);
        //GUILayoutOption[] options = new GUILayoutOption[] { GUILayout.MaxWidth(20), GUILayout.MaxHeight(10) };
        GUIContent content = new GUIContent();
        content.text = "颜色";
        content.tooltip = "颜色选择";
        sample.colorValue = EditorGUILayout.ColorField(content, sample.colorValue,true,true,true);
        sample.aCurve = EditorGUILayout.CurveField("AnimationCurve", sample.aCurve, Color.yellow, new Rect(50, 50, 50, 50));
    }

    [MenuItem("Assets/Delete")]
    static void delete()
    {
        GameObject prefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/GameObject.prefab");
        //删除MeshCollider
        MeshCollider[] meshColliders = prefab.GetComponentsInChildren<MeshCollider>(true);
        foreach (var meshCollider in meshColliders)
        {
            GameObject.DestroyImmediate(meshCollider, true);
        }

        MonoBehaviour[] monoBehaviours = prefab.GetComponentsInChildren<MonoBehaviour>(true);
        foreach (MonoBehaviour monoBehaviour in monoBehaviours)
        {
            if (monoBehaviour == null)
            {
                Debug.Log("有个missing的脚本");
                //GameObject.DestroyImmediate(monoBehaviour,true);

            }
        }
    }
}
