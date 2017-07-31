using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class NpcController : MonoBehaviour
{
    public WaypointsController waypoints;
    
    public Animator animator;
    
    private WayPoint _nextWaypoint;
    private float jobRemaining;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    private void TargetNextWaypoint()
    {
        if (!waypoints) Debug.LogError("waypoints controller not specified!");
        _nextWaypoint = waypoints.GiveMeRandom(_nextWaypoint);
        jobRemaining = Random.Range(_nextWaypoint.MinTime, _nextWaypoint.MaxTime);
    }

    // Update is called once per frame
    private void Update ()
    {
        if (!_nextWaypoint)
        {
            TargetNextWaypoint();
        }
        
        var pos = transform.position;

        var dir = _nextWaypoint.transform.position - pos;

        if (dir.magnitude < 1f)
        {
            jobRemaining -= Time.deltaTime;

            if (_nextWaypoint.Gadget)
                _nextWaypoint.Gadget.StartUse();
            
            if (jobRemaining < 0)
            {
                if (_nextWaypoint.Gadget)
                    _nextWaypoint.Gadget.StopUse();
                TargetNextWaypoint();
            }            
        }
        
        var speed = 2f;

        if (dir.magnitude < 0.1f)
            speed = 0;
        
        dir.Normalize();
        
        var motion = dir * speed * Time.deltaTime;
        
        pos += motion;

        transform.localScale = new Vector3(motion.x > 0.01 ? -1 : 1, 1, 1);

        
        if (Math.Abs(motion.x) > 0.01) animator.SetTrigger("leftRight");
        else if (motion.y > 0.01) animator.SetTrigger("up");
        else if (motion.y < -0.01) animator.SetTrigger("down");
        else animator.SetTrigger("idle");
        
        transform.position = pos;
    }
}