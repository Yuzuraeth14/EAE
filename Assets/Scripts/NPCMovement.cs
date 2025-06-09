using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public Transform[] waypoints;  // Array to hold the waypoints
    public float moveSpeed = 2f;    // NPC movement speed
    private int waypointIndex = 0;  // Current waypoint index

    void Start()
    {
        // Set the NPC's initial position to the first waypoint
        transform.position = waypoints[waypointIndex].transform.position;
    }

    void Update()
    {
        // Move the NPC towards the current waypoint
        Move();
    }

    void Move()
    {
        // Move the NPC towards the current waypoint
        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointIndex].position, moveSpeed * Time.deltaTime);

        // Check if the NPC has reached the waypoint
        if (transform.position == waypoints[waypointIndex].position)
        {
            // Go to the next waypoint
            waypointIndex++;

            // Loop back to the first waypoint if the last one is reached
            if (waypointIndex >= waypoints.Length)
            {
                waypointIndex = 0;
            }
        }
    }
}


