using UnityEngine;
using UnityEditor;
using Object = UnityEngine.Object;
public class GUIDToAssetWindow : EditorWindow
{
    private string _instanceIDInput;
    private Object _foundObject;

    [MenuItem("Utils/GUIDToAsset")]
    public static void ShowWindow()
    {
        GetWindow<GUIDToAssetWindow>("GUID to Asset window");
    }

    private void OnGUI()
    {
        GUILayout.Label("Найти Объект по Instance ID:", EditorStyles.whiteLargeLabel);

        _instanceIDInput = EditorGUILayout.TextField("Instance ID: ", _instanceIDInput);

        if (GUILayout.Button("Найти"))
        {
            FindObjectByInstanceID();
        }
        
        if (_foundObject != null)
        {
            EditorGUILayout.ObjectField("Объект найден: ", _foundObject, typeof(Object),true);
        } 
        else if (!string.IsNullOrEmpty(_instanceIDInput))
        {
            EditorGUILayout.LabelField($"Объект с ID - {_instanceIDInput} не найден.");
        }
    }

    private void FindObjectByInstanceID()
    {
        if (int.TryParse(_instanceIDInput, out int instanceID))
        {
            _foundObject = EditorUtility.InstanceIDToObject(instanceID);

            if (_foundObject == null)
            {
                Debug.LogWarning($"Объект с Instance ID {instanceID} не найден.");
            }
        }
        else
        {
            Debug.LogError("Нерпавильный формат Instance ID. Должно быть целое число.");
        }
    }
}
