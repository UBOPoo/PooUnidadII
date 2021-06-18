using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMetal : MonoBehaviour
{
    public delegate void FNotifyPlayerFound(Vector3 PlayerPosition);
    public static event FNotifyPlayerFound OnPlayerFound;

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

    private void OnDisable()
    {
        EnemyMetal.OnPlayerFound -= EnemyMetal_OnPlayerFound;
    }
    private void OnEnable()
    {
        EnemyMetal.OnPlayerFound += EnemyMetal_OnPlayerFound;
    }

    private void EnemyMetal_OnPlayerFound(Vector3 PlayerPosition)
    {
        CancelInvoke();
        agent.SetDestination(PlayerPosition);
    }

    public void PlayerDetected(Transform Player)
    {
        OnPlayerFound?.Invoke(Player.position);
    }
    void FindRandomPath()
    {

        Vector3 randomPosition = Random.insideUnitSphere*maxDistance;
        randomPosition.y = transform.position.y;

        agent.SetDestination(randomPosition);

    }
     
}
