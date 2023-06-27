using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rgbd;
    public float flatStrength;
    public float bottomEdge;
    private LogicScript logic;
    private bool isAlive = true;
    public AudioSource deadSound;
    public AudioSource jumpSound;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rgbd.velocity = Vector2.up * flatStrength;
                jumpSound.Play();
            }

            if (transform.position.y < bottomEdge)
            {
                Over();
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (isAlive)
        {
            Over();
        }
    }

    private void Over()
    {
        isAlive = false;
        deadSound.Play();
        logic.GameOver();
    }
}
