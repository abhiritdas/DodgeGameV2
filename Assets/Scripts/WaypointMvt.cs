using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMvt : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;
    Vector3 Vel;
    // Start is called before the first frame update
    void Start()
    {
        Vel = new Vector3(0, 4, 0f);
        rb.velocity = Vel;
    }

    // Update is called once per frame
    void Update()
    {
        if ((rb.position.y > 9.0 && rb.position.y < -8.9))
        {
            Debug.Log("move right");
            Vel = new Vector3(4, 0, 0f);
            rb.velocity = Vel;
        }

        if ((rb.position.x < -12.4 && rb.position.x > -12.7) &&(rb.position.y > 9.0 && rb.position.y < -8.9) )
        {
            Debug.Log("move down");
            Vel = new Vector3(0, -4, 0f);
            rb.velocity = Vel;
        }

        if (rb.position.y < -2.0 && rb.position.y > -2.4)
        {
            Debug.Log("move left");
            Vel = new Vector3(-4, 0, 0f);
            rb.velocity = Vel;
        }

        if (rb.position.x < -5.5 && rb.position.x > -5.6 && ! (rb.position.y < -2.0 && rb.position.y > -2.4))
        {
            Debug.Log("move up");
            Vel = new Vector3(0, 4, 0f);
            rb.velocity = Vel;
        }


    }

    // public Vector3[] points = new Vector3[4]; // In the editor, put your rectangle coordinates in here
    // private int nextPointIndex = 0;
    // public double speed;

    // private void Start()
    // {
    //     points[0] = (-12.5, -2.5, 0f);
    //     points[1] = (-5.8, -2.5, 0f);
    //     points[2] = (-5.8, -9, 0f);
    //     points[3] = (-12.5, -9, 0f);
    // }

    // private void Update()
    // {
    // var reachedNextPoint = transform.position == points[nextPointIndex];
    
    // if (reachedNextPoint)
    // {
    //     nextPointIndex++;
    //     if (nextPointIndex >= points.Length)
    //     {
    //     nextPointIndex = 0;
    //     }
    // }
    
    // transform.position = Vector3.MoveTowards(transform.position, points[nextPointIndex], speed * Time.deltaTime);
    // }
}
