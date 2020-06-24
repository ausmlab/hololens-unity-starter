using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    
    public Camera cam;
    public NavMeshAgent agent;
    public Transform destination;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
    
}
