using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Move_Left_Right : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float moveSpeed;

    private int currPoint;

    void Start()
    {
        transform.position = patrolPoints[0].position;
        currPoint = 0;
    }

    void Update()
    {
        if(transform.position == patrolPoints[currPoint].position)
        {
            currPoint++;
        }
        if(currPoint >= patrolPoints.Length)
        {
            currPoint = 0;
        }
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currPoint].position, moveSpeed*Time.deltaTime);
    }
}
