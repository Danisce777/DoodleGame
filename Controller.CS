using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    private Rigidbody2D RB2D;
    private float MoveInput;
    private float speed = 20f;

    private float topScore = 0.0f;

    public Text scoreText;


    // Start is called before the first frame update
    void Start()
    {

        RB2D = GetComponent<Rigidbody2D>();

    }

     void Update()
    {
        if(RB2D.velocity.y > 0 && transform.position.y > topScore) 
        {
            topScore = transform.position.y;
        
        }

        scoreText.text = "Score: " + Mathf.Round(topScore).ToString();

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        MoveInput = Input.GetAxis("Horizontal");
        RB2D.velocity = new Vector2(MoveInput * speed, RB2D.velocity.y);
    }
}
