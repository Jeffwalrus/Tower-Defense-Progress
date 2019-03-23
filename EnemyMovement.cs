﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public float speed = 10.0f;

    private Transform target;

    private int wavepointindex = 0;

	// Use this for initialization
	void Start ()
    {
        target = Waypoints.waypoints[0];	
	}

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.2f)
        {
            GetNextWayPoint();
        }
    }

        void GetNextWayPoint()
        {
        if (wavepointindex >= Waypoints.waypoints.Length - 1)
        {
            Destroy(gameObject);
        }
            wavepointindex++;
            target = Waypoints.waypoints[wavepointindex];

        }

	
}
