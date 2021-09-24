using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{

    [SerializeField] private WayPoint[] _wayPoints;



    public WayPoint GetPathStart()
    {
        return _wayPoints[0];
    }

    public WayPoint GetPathEnd()
    {
        return _wayPoints[_wayPoints.Length - 1];
    }

    public WayPoint GetNextWayPoint(WayPoint currentWayPoint)
    {
        for(int i = 0; i < _wayPoints.Length; i++)
        {
             if(_wayPoints[i] == currentWayPoint)
            {
                return _wayPoints[i + 1];
            }
        }
        return null;
    }
}
