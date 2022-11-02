using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 3f;

    public float distanceThreshold = 0.5f;

    public enum EnemyState { Follow, Chase }
    EnemyState currentState;

    Waypoints waypoints;
    Transform currentWaypoint;

    // Start is called before the first frame update
    void Start()
    {
        currentState = EnemyState.Follow;

        waypoints = GameObject.Find("Waypoints").GetComponent<Waypoints>();

        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        transform.position = currentWaypoint.position;

        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentWaypoint.position) < distanceThreshold)
        {
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
        }
    }
}
