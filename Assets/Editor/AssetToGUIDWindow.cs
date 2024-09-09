using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

public class AssetToGUIDWindow : EditorWindow
{
    private List<Object> _droppedObjects = new();

    [MenuItem("Utils/AssetToGUID")]
    public static void ShowWindow()
    {
        GetWindow<AssetToGUIDWindow>("Asset to GUID window");
    }

    private void OnGUI()
    {
        GUILayout.Label("Перетащи ассет в поле ниже:", EditorStyles.whiteLargeLabel);

        Rect dropArea = GUILayoutUtility.GetRect(0.0f, 50.0f, GUILayout.ExpandWidth(true));
        GUI.Box(dropArea, "Drag and Drop зона", EditorStyles.helpBox);

        HandleDragAndDrop(dropArea);
        
        foreach (var droppedObject in _droppedObjects)
        {
            EditorGUILayout.ObjectField("Перетянутый объект: ", droppedObject, typeof(Object), true);
            EditorGUILayout.LabelField("Instance ID: ", droppedObject.GetInstanceID().ToString());
        }
    }

    private void HandleDragAndDrop(Rect dropArea)
    {
        var currentEvent = Event.current;
        
        if (!dropArea.Contains(currentEvent.mousePosition))
            return;
        
        switch (currentEvent.type) 
        {
            case EventType.DragUpdated:
            case EventType.DragPerform:
                DragAndDrop.visualMode = DragAndDropVisualMode.Copy;

                if (currentEvent.type == EventType.DragPerform)
                {
                    _droppedObjects.Clear();
                    DragAndDrop.AcceptDrag();
                    foreach (var draggedObject in DragAndDrop.objectReferences)
                    {
                        _droppedObjects.Add(draggedObject);
                    }
                }
                Event.current.Use();
                break;
        }
    }
}