using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class WaypointsController : MonoBehaviour
{
    public Color GizmoColor = Color.magenta;
    
    private List<WayPoint> waypoints;

    void Start()
    {
//        Debug.Log("Start WP");
        waypoints = GetComponentsInChildren<WayPoint>().ToList();
    }
	
    void OnDrawGizmos ()
    {
        Gizmos.color = GizmoColor;
        
        var ts = GetComponentsInChildren<WayPoint>().ToList();

        foreach (var t in ts)
        {
            // Gizmos.DrawLine(transforms[i - 1].position, transforms[i].position);
            Gizmos.DrawWireSphere(t.transform.position, 0.2f);
        }
    }

    public WayPoint GiveMeRandom(WayPoint previous)
    {
//        Debug.Log("waypoints: " + waypoints);
        var ix = Random.Range(0, waypoints.Count);
//        Debug.Log("GetRandom: " + ix);
        
        var wp = waypoints[ix];
        waypoints.Remove(wp);
        
        if (previous)
            waypoints.Add(previous);
        
        return wp;
    }
}