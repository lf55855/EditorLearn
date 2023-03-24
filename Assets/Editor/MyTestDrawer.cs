using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
//PropertyDrawer 有两种用途：
//-自定义 Serializable 类的每个实例的 GUI。
//- 自定义具有自定义 PropertyAttribute 的脚本成员的 GUI。
[CustomPropertyDrawer(typeof(MyTestAttribute))]
public class MyTestDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        MyTestAttribute attribute = (MyTestAttribute)base.attribute;
        property.intValue = Mathf.Min(Mathf.Max(EditorGUI.IntField(position, label.text, property.intValue), attribute.min), attribute.max);
    }
}
