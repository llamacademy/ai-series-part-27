using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(AIManager))]
public class AIManagerEditor : Editor
{
    private void OnSceneGUI()
    {
        AIManager aiManager = (AIManager)target;
        if (aiManager == null)
        {
            return;
        }

        for (int i = 0; i < aiManager.Units.Count; i++)
        {
            Handles.SphereHandleCap(GUIUtility.GetControlID(FocusType.Passive), aiManager.Units[i].Agent.destination, Quaternion.identity, 0.25f, EventType.Repaint);
        }
    }
}
