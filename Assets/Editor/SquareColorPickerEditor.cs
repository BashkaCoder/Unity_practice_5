using System;
using UnityEditor;
using UnityEngine;
using System.Reflection;
using Random = UnityEngine.Random;

[CustomEditor(typeof(SquareColorPicker))]
public class SquareColorPickerEditor : Editor
{
    private Color color;

    public override void OnInspectorGUI()
    {
        SquareColorPicker myTarget = (SquareColorPicker) target;
        Type myType = typeof(SquareColorPicker);
        FieldInfo targetColor = myType.GetField("_color", BindingFlags.Instance | BindingFlags.NonPublic);
        
        color = (Color) targetColor?.GetValue(myTarget);

        color.r = EditorGUILayout.FloatField("Red: ", color.r);
        color.g = EditorGUILayout.FloatField("Green: ", color.g);
        color.b = EditorGUILayout.FloatField("Blue: ", color.b);
        
        color = EditorGUILayout.ColorField("Color", color);
        if (GUI.changed)
        {
            targetColor?.SetValue(myTarget, color);
        }
        
        if(GUILayout.Button("Randomize Color"))
        {
            color = new Color(Random.value, Random.value, Random.value);
            targetColor?.SetValue(myTarget, color);
        }
    }
}
