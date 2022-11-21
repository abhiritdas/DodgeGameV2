using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class HorizontalBullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed;
    Vector3 Vel;
    private Vector3 startPos;
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector3(rb.transform.position.x, rb.transform.position.y, rb.transform.position.z);
        Vel = new Vector3(Speed, 0, 0f);
        rb.velocity = Vel;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.transform.position = startPos;
        Vel = new Vector3(Speed, 0, 0f);
        rb.velocity = Vel;
        audioSource.Play();
    }
}
