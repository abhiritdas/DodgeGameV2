using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool up, down, left, right;
    [SerializeField] float speed;
    private Vector3 startPos;
    public Rigidbody2D rb;
    public GameObject Life1;
    public GameObject Life2;
    public GameObject Life3;
    public GameObject youWinText;
    public GameObject gameOverText;
    Vector3 VelReal;
    bool final = false;
    int life = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector3(rb.transform.position.x, rb.transform.position.y, rb.transform.position.z);
        youWinText.SetActive(false);
        gameOverText.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if(!final){
            if (Input.GetKeyDown(KeyCode.W))
            {
                up = true;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                left = true;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                down = true;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                right = true;
            }


            if (Input.GetKeyUp(KeyCode.W))
            {
                up = false;
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                left = false;
            }
            if (Input.GetKeyUp(KeyCode.S))
            {
                down = false;
            }
            if (Input.GetKeyUp(KeyCode.D))
            {
                right = false;
            }
        }

        else{
            VelReal = new Vector3(0, 0f); 
        }


    if (Input.GetKey(KeyCode.R))
        {
            life = 3;
            Life1.SetActive(true);
            Life2.SetActive(true);
            Life3.SetActive(true);

            gameOverText.SetActive(false);
            youWinText.SetActive(false);
            final = false;
            rb.transform.position = startPos;


        }


    }



    private void FixedUpdate()
    {
        float xChange = 0f;
        float yChange = 0f;


        if (up)
        {
            yChange += speed;
        }
        if (left)
        {
            xChange -= speed;
        }
        if (down)
        {
            yChange -= speed;
        }
        if (right)
        {
            xChange += speed;
        }

        GetComponent<Transform>().position += new Vector3(xChange * Time.deltaTime, yChange * Time.deltaTime, 0);

    }



   void OnCollisionEnter2D(Collision2D col)
    {
        GameObject[] objectsAll= {Life1, Life2, Life3 };
        if (col.gameObject.CompareTag("Player")) {
            objectsAll[life - 1].SetActive(false);
            rb.transform.position = startPos;

            VelReal = new Vector3(0, 0, 0f);
            rb.velocity = VelReal;

            if (life == 1)
            {
                rb.transform.position = startPos;
                gameOverText.SetActive(true);
                final = true;
            }

            else{
              life = life - 1;  
            }
        }

        if (col.gameObject.CompareTag("Finish"))
        {
            youWinText.SetActive(true);
            final = true;
        }
    }
}