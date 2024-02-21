
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent _NMAgent;
    private bool _isPlayerNoticed;

    public List<Transform> PatrolPoints;
    public PlayerController player;
    public float ViewAngle;
    public float NoticeDistace;
    void Start()
    {
        InitComponents();
    }
    void Update()
    {
        AgentPickPointUpdate();
        NoticePlayerUpdate();
        ChaseUpdate();
    }
    private void AgentPickPointUpdate() {if (!_NMAgent.hasPath && !_isPlayerNoticed) _NMAgent.destination = PatrolPoints[Random.Range(0, PatrolPoints.Count)].position;}
    private void NoticePlayerUpdate()
    {
        var direction = player.transform.position - transform.position;
        var _distance=Vector3.Distance(player.transform.position,transform.position);
        _isPlayerNoticed = false;
        if (Vector3.Angle(transform.forward, direction) < ViewAngle || _distance< NoticeDistace)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position + Vector3.up, direction, out hit))
            {
                if (hit.collider.gameObject == player.gameObject) _isPlayerNoticed = true;
            }
        }
    }
    private void ChaseUpdate()
    {
        if (_isPlayerNoticed) _NMAgent.destination = player.transform.position;
    }
    private void InitComponents()
    {
        _NMAgent = GetComponent<NavMeshAgent>();
    }
}
