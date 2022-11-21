using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSprites : MonoBehaviour
{
    private Vector3 offset;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.name == "Life1"){
            offset = new Vector3(-7f, 4, 1); 
        }
        if(gameObject.name == "Life2"){
            offset = new Vector3(-6f, 4, 1); 
        }
        if(gameObject.name == "Life3"){
            offset = new Vector3(-5f, 4, 1); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, 0.0f);
    }
}
