using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
//PropertyDrawer ��������;��
//-�Զ��� Serializable ���ÿ��ʵ���� GUI��
//- �Զ�������Զ��� PropertyAttribute �Ľű���Ա�� GUI��
[CustomPropertyDrawer(typeof(MyTestAttribute))]
public class MyTestDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        MyTestAttribute attribute = (MyTestAttribute)base.attribute;
        property.intValue = Mathf.Min(Mathf.Max(EditorGUI.IntField(position, label.text, property.intValue), attribute.min), attribute.max);
    }
}
