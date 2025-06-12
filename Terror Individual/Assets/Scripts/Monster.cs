using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public enum MonsterState 
{
   Idle, LookingFor, Chase
}

public class Monster : MonoBehaviour
{
    MonsterState state;
    NavMeshAgent agent;
    [SerializeField] Transform player;
    [SerializeField] Transform[] patrolPoints;
    private float waitTime = 2;
    [SerializeField] UnityEvent OnJumpScare;
    [SerializeField] GameObject jumpScare;
    [SerializeField] float visonAgle;

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
                      
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            OnJumpScare.Invoke();
            jumpScare.SetActive(true);
        }
    }

   
}

