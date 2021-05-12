using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScrpt : MonoBehaviour
{

    public float ballSpeed;
    public float inc;
    Vector2 ballDirection;

    Rigidbody2D rb;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ballDirection = Vector2.one.normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = ballDirection * ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Wall"))
        {
            ballDirection.y = -ballDirection.y;
        }
        else if (collision.gameObject.CompareTag("Block"))
        {
            ballDirection.x = -ballDirection.x;
            ballSpeed += inc;
        }
    }

    private void Update()
    {
        if(transform.position.x < -15.5 || transform.position.x > 15.5 || transform.position.y > 5.7 || transform.position.y < -5.7)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
