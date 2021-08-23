using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
[DefaultExecutionOrder(1)]
public class AIUnit : MonoBehaviour
{
    public NavMeshAgent Agent;

    private void Awake()
    {
        Agent = GetComponent<NavMeshAgent>();
        AIManager.Instance.Units.Add(this);
    }

    public void MoveTo(Vector3 Position)
    {
        Agent.SetDestination(Position);
    }
}
