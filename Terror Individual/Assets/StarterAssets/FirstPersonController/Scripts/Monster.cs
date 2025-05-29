using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public enum MonsterStates 
{
    LOOKING, CHASE, PATROL, PLAYERVIEW, WAIT
}

public class Monster : MonoBehaviour
{
    MonsterStates state;
    NavMeshAgent agent;
    [SerializeField] Transform player;
    [SerializeField] Transform[] patrolPoints;
    private float waitTime;

    public MonsterStates State { get => state; set => state = value; }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Looking();
        //agent.SetDestination(player.position);

        switch (state)
        {
            case MonsterStates.WAIT:
                break;
            case MonsterStates.LOOKING:
                if (agent.remainingDistance <= agent.stoppingDistance)
                {
                    SetState(MonsterStates.WAIT);
                }
                break;
            case MonsterStates.CHASE:
                agent.SetDestination(player.position);
                break;
            case MonsterStates.PLAYERVIEW:
                break;

        }
    }

   public void SetState(MonsterStates newState)
   {
        switch (newState)
        {
            case MonsterStates.WAIT:
                StartCoroutine(LookForPlayer());
                break;
            case MonsterStates.LOOKING:
                agent.SetDestination(patrolPoints[Random.Range(0, patrolPoints.Length)].position);
                break;
            case MonsterStates.CHASE:
                break;
            case MonsterStates.PLAYERVIEW:
                break;

        }
        state = newState;

   }

    IEnumerator LookForPlayer()
    {
        yield return new WaitForSeconds(waitTime);
        SetState(MonsterStates.PATROL);
    }

    public void Looking()
    {
        if (!Physics.Linecast(transform.position, player.position))
        {
            SetState(MonsterStates.CHASE);
        }
        else

        {
            if (!state.Equals(MonsterStates.CHASE))
                return;


            SetState(MonsterStates.PLAYERVIEW);
        }
    }
}

