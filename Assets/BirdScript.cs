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

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            rgbd.velocity = Vector2.up * flatStrength;
        }

        if (transform.position.y < bottomEdge)
        {
            Over();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Over();
    }

    private void Over()
    {
        isAlive = false;
        logic.GameOver();
    }
}
