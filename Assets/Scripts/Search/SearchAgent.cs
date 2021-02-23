using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchAgent : MonoBehaviour
{
    public WaypointNode waypoint;

    void Update()
    {
        if (waypoint != null)
        {
            Vector3 direction = waypoint.transform.position - transform.position;
            transform.position += direction.normalized * 2 * Time.deltaTime;
        }
    }
}
