using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMetal : MonoBehaviour
{
    NavMeshAgent agent;
    public float maxDistance = 10f;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    // Start is called before the first frame update
    void Start()
    {
      
        InvokeRepeating("FindRandomPath", 0, 3);
    }

    public void PlayerDetected(Transform Player)
    {
      
    }
    void FindRandomPath()
    {

        Vector3 randomPosition = Random.insideUnitSphere*maxDistance;
        randomPosition.y = transform.position.y;

        agent.SetDestination(randomPosition);

    }
     
}
