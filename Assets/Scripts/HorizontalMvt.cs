using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMvt : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;
    Vector3 Vel;
    // Start is called before the first frame update
    void Start()
    {
        Vel = new Vector3(4, 0, 0f);
        rb.velocity = Vel;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Speed = -Speed;
        Vel = new Vector3(Speed, 0, 0f);
        rb.velocity = Vel;
    }
}
