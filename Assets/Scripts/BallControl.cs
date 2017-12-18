using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    //Getting a refence to the rigidbody component
    Rigidbody2D rb;
	
	void Start () {

        //Shorcut to rigidbody component
        rb = GetComponent<Rigidbody2D>();

        //Delay ball logic for 3 seconds
        StartCoroutine(Stop());


	}
	
	// Update is called once per frame
	void Update () {

        //If ball goes to the left...
        if (transform.position.x < -15f)



        //Player 2 Scores a point

        {
            transform.position = Vector3.zero;
            rb.velocity = Vector3.zero;

            Scoreboard.instance.P2Scored();
            StartCoroutine(Stop());

        }


        //If ball goes to the right...
        if (transform.position.x > 10f)
   

        {
            transform.position = Vector3.zero;
            rb.velocity = Vector3.zero;
            //Player 1 Scores a point



            Scoreboard.instance.P1Scored();
            StartCoroutine(Stop());


        }

    }
    
    IEnumerator Stop()
    {
        // Delay ball to start
        yield return new WaitForSeconds(1.5f);

        //Call the function that launches randomly the ball
        StartBall();

    }

    void StartBall() {

        transform.position = Vector3.zero;
        //Where the ball flies at start
        //Random Generated number for the x-axis
        int xaxisDirection = Random.Range(0, 2);


        //Random Generated number for the y-axis
        int yaxisDirection = Random.Range(0, 3);

        Vector3 flyDirection = new Vector3();

        if (xaxisDirection == 0)
        {

            flyDirection.x = -5f;
        }
        if (xaxisDirection == 1)
        {

            flyDirection.x = 5f;
        }
        //
        if (yaxisDirection == 0)
        {

            flyDirection.y = -5f;
        }
        if (yaxisDirection == 1)
        {

            flyDirection.y = 5f;
        }
        if (yaxisDirection == 2)
        {

            flyDirection.y = 0f;
        }

        rb.velocity = flyDirection;
    }



    // When the object hit something
    void OnCollisionEnter2D (Collision2D hit)
    {
    // If it was the top collidor
    if(hit.gameObject.name == "Top Collidor")
        {
            float XDirectionSpeed = 0f;

            if (rb.velocity.x > 0f)
                XDirectionSpeed = 5f;

            if (rb.velocity.x < 0f)
                XDirectionSpeed = -5f;

            rb.velocity = new Vector3(XDirectionSpeed, -5f, 0f);

        }
        // If it was the bot collidor change direction
        if (hit.gameObject.name == "Bot Collidor")
        {

            float XDirectionSpeed = 0f;

            if (rb.velocity.x > 0f)
                XDirectionSpeed = 5f;

            if (rb.velocity.x < 0f)
                XDirectionSpeed = -5f;

            rb.velocity = new Vector3(XDirectionSpeed, 5f, 0f);
        }

        //If it hits the paddles p1

        if (hit.gameObject.name == "Paddle P1")
        { 


            rb.velocity = new Vector3(3f, 0f, 0f);
        

            if (transform.position.y - hit.gameObject.transform.position.y < -0.56)
            {

                rb.velocity = new Vector3(5f, -5f, 0f);
            }
            //Check if we hit lower half of the bat...
            if (transform.position.y - hit.gameObject.transform.position.y > 0.26)
            {

                rb.velocity = new Vector3(5f, 5f, 0f);
            }


        }
        if (hit.gameObject.name == "Paddle P2") {


            //Check if we hit lower half of the bat...
            if (transform.position.y - hit.gameObject.transform.position.y < -0.56)
            {

                rb.velocity = new Vector3(-5f, -5f, 0f);
            }
            //Check if we hit lower half of the bat...
            if (transform.position.y - hit.gameObject.transform.position.y > 0.26)
            {

                rb.velocity = new Vector3(-5f, 5f, 0f);
            }
        }

    }

}
