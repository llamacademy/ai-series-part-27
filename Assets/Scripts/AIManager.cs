using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(0)]
public class AIManager : MonoBehaviour
{
    private static AIManager _instance;
    public static AIManager Instance
    {
        get
        {
            return _instance;
        }
        private set
        {
            _instance = value;
        }
    }

    public Transform Target;
    public float RadiusAroundTarget = 0.5f;
    public List<AIUnit> Units = new List<AIUnit>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            return;
        }

        Destroy(gameObject);
    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(20, 20, 200, 50), "Move To Target"))
        {
            MakeAgentsCircleTarget();
        }
    }

    private void MakeAgentsCircleTarget()
    {
        for (int i = 0; i < Units.Count; i++)
        {
            Units[i].MoveTo(new Vector3(
                Target.position.x + RadiusAroundTarget * Mathf.Cos(2 * Mathf.PI * i / Units.Count),
                Target.position.y,
                Target.position.z + RadiusAroundTarget * Mathf.Sin(2 * Mathf.PI * i / Units.Count)
                ));
        }
    }
}
