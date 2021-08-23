using UnityEngine;
using UnityEngine.AI;

public class PlayerInput : MonoBehaviour
{
    [SerializeField]
    private Camera Camera;
    [SerializeField]
    private LayerMask FloorLayers;
    [SerializeField]
    private NavMeshAgent Agent;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            if (Physics.Raycast(Camera.ScreenPointToRay(Input.mousePosition), out RaycastHit Hit, FloorLayers))
            {
                Agent.SetDestination(Hit.point);
            }
        }
    }
}