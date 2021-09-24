using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    [SerializeField] float _speed;
    [SerializeField] private float _ArrivalThreshold;
    Path _path;
    WayPoint _currentWayPoint;

    private void Start()
    {
        SetupPath();
    }

    void SetupPath()
    {
        _path = FindObjectOfType<Path>();
        _currentWayPoint = _path.GetPathStart();
        transform.LookAt(_currentWayPoint.GetPosition());
    }


    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(_currentWayPoint.GetPosition());
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        // 1. ben ik in de buurt van current waypoint
        float DistanceToWayPoint = Vector3.Distance(transform.position, _currentWayPoint.GetPosition());
        if(DistanceToWayPoint <= _ArrivalThreshold)
        {
            print("I am near the point");
            // 1.1. zo, ja, is dit mijn eindpunt?
            if (_currentWayPoint == _path.GetPathEnd())
            {
                // 1.1.1. roep pathcomplete aan
                PathCompleter();
            }
            else
            {
                // 1.2 zo nee, vraag volgende waypoint op
                _currentWayPoint = _path.GetNextWayPoint(_currentWayPoint);
                // 1.2.1 roteer naar nieuwe waypoint
                transform.LookAt(_currentWayPoint.GetPosition());
            }


        }
        
           
           

        //Beschrijf in psyedo code of comments
        //wat moet er gebeuren in de update van pathfollower
        // hint, je hebt de variabelen nodig in deze class gedefineerd zijn

        // Threshold gebruiken om te kijken hoever je van het waypoint bent
        // als afstand tussen enemy en wp kleiner is dan threshold
        // dan moet currentwaypoint volgende waypoint worden
    }

    void PathCompleter()
    {
        print("Ik ben bij het eindpunt");
        _speed = 0.0f;
    }
}
