using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb2;
    public float velocity = 20;
    public GameObject explosion;
    void Start()
    {
        var player = GameObject.Find("Player").GetComponent<Rigidbody2D>();

        rb2 = GetComponent<Rigidbody2D>();
        rb2.rotation = player.rotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2.MovePosition(transform.position + transform.up * velocity * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("meteor"))
        {
 
            var e = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(other.gameObject);

            Destroy(gameObject);
           
        }

    }
}
