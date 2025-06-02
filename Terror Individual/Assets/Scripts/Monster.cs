using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public enum MonsterState 
{
   Idle, LookingFor, Chase, Frozen
}

public class Monster : MonoBehaviour
{
    MonsterState state;
    NavMeshAgent agent;
    [SerializeField] Transform player;
    [SerializeField] Transform[] patrolPoints;
    private float waitTime = 2;

    public MonsterState State { get => state; set => state = value; }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        SetState(MonsterState.LookingFor);
    }

    // Update is called once per frame
    void Update()
    {
       Looking();
        //agent.SetDestination(player.position);
        //if (agent.remainingDistance <= agent.stoppingDistance){ }

        switch (state)
        {
            case MonsterState.Idle:
                break;
            case MonsterState.LookingFor:
                if (agent.remainingDistance <= agent.stoppingDistance)
                {
                    SetState(MonsterState.Idle);
                }
                break;
            case MonsterState.Chase:
                agent.SetDestination(player.position);
                break;
            case MonsterState.Frozen:            
                break;
        }
    }

   public void SetState(MonsterState newState)
   {
        switch (newState)
        {
            case MonsterState.Idle:
                StartCoroutine(Waitting());
                break;
            case MonsterState.LookingFor:
                agent.SetDestination(patrolPoints[Random.Range(0, patrolPoints.Length)].position);
                break;
            case MonsterState.Chase:
                agent.SetDestination(player.position);
                break;
            case MonsterState.Frozen:
                break;
        }
        state = newState;

   }

    IEnumerator Waitting()
    {
        yield return new WaitForSeconds(waitTime);
        SetState(MonsterState.LookingFor);
    }

    public void Looking()
    {
        if (!Physics.Linecast(transform.position, player.position))
        {
            SetState(MonsterState.Chase);
        }
        else

        {
            if (!state.Equals(MonsterState.Chase))
                return;


            SetState(MonsterState.Frozen);
        }
    }
}

