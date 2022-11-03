using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float waypointsDistanceThreshold = 0.5f;
    float distanceBetweenWaypoint = 0;
    Waypoints waypoints;
    Transform currentWaypoint;

    [HideInInspector] public Transform startTransform;

    private void Awake()
    {
        startTransform = transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        waypoints = FindObjectOfType<Waypoints>();
        currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentWaypoint == null)
            return;

        transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, currentWaypoint.position) < waypointsDistanceThreshold)
        {
            currentWaypoint = waypoints.GetNextWaypoint(currentWaypoint);
            if (currentWaypoint.position.x < transform.position.x)
            {
                if (transform.localScale.x > 0)
                    transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            }
            else if (currentWaypoint.position.x > transform.position.x)
            {
                if (transform.localScale.x < 0)
                    transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
            }
        }
    }
}
