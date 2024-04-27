using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float yForce;
    private Rigidbody2D enemyRigidBody;

    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(0, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }
    }

    private void FixedUpdate()
    {
        /*
        if (transform.position.x <= -8 || transform.position.x >= 8)
        {
            speed = -speed;
        }    
        float newXPosition = transform.position.x + speed * Time.deltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        transform.position = newPosition;
        */
    }
}
