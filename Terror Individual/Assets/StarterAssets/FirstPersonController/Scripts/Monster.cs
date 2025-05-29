using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public enum MonsterStates 
{
    LOOKING, CHASE, PLAYERVIEW
}

public class Monster : MonoBehaviour
{
    MonsterStates monsters;
    NavMeshAgent agent;
    [SerializeField] Transform player;
    [SerializeField] Transform[] patrolPoints;

   
    public MonsterStates Monsters { get => monsters; set => monsters = value; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.position);
    }

    
}
