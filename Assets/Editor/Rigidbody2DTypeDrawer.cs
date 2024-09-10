using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Rigidbody2DTypeAttribute))]
public class Rigidbody2DTypeDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var bodyTypeAttribute = attribute as Rigidbody2DTypeAttribute ;
        
        if (property.objectReferenceValue != null && property.objectReferenceValue is Rigidbody2D)
        {
            var rigidbody2D = property.objectReferenceValue as Rigidbody2D ;
            rigidbody2D.bodyType = bodyTypeAttribute.BodyType;
            EditorGUI.PropertyField(position, property, label);
        }
        else
        {
            EditorGUI.LabelField(position, label.text, "Может быть применено только к Rigidbody2D");
        }
    }
}