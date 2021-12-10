using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBird : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private bool isDead = false;
    private Rigidbody2D rb;
    public bool invulnerable = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead) { 
            float angle = Mathf.Atan2(rb.velocity.y, 10) * Mathf.Rad2Deg;
            rb.transform.rotation = Quaternion.Euler(new Vector3(x: 0, y: 0, z: angle));

            if (Input.GetMouseButtonDown(0))
            {
                //jump
                rb.velocity = Vector2.up * velocity;
            }else if (Input.GetKey(KeyCode.Space))
            {
                rb.velocity = Vector2.up * velocity;
            }
        }else
        {
            if (Input.GetKey(KeyCode.Space))
            {
                gameManager.Replay();
                isDead = false;
            }
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!invulnerable)
        {
            gameManager.GameOver();
            isDead = true;
        }
    }

    
}
