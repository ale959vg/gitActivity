using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float direction;
    private float rotation;
    public float velocity = 10;
    public float rotationVelocity = 50;
    public float Health = 10;
    private Vector3 disDob;
   
    public GameObject shoot;

    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        disDob = new Vector3 (0.3f, 0.0f, 0.0f);
    }

    void Update()
    {
        direction = 0.0f;
        rotation = 0.0f;
        rotation = Input.GetAxisRaw("Horizontal");
        direction = Input.GetAxisRaw("Vertical");
  
        if(Input.GetMouseButtonDown(0))
        {
            disparar();
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            disparoDoble();
  
        }

    }
    // Update is called once per frame

    void disparar()
    {
        Instantiate(shoot, transform.position, Quaternion.identity);
    }
    void disparoDoble()
    {
     
        Instantiate(shoot, transform.position + disDob, Quaternion.identity);
        Instantiate(shoot, transform.position - disDob, Quaternion.identity);
    }
    void FixedUpdate()
    {  

        rb.MovePosition(transform.position + transform.up * direction * velocity * Time.deltaTime);

        rb.transform.Rotate(0.0f, 0.0f, -rotation * rotationVelocity * Time.deltaTime, Space.Self);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag.Equals("meteor"))
        {
            Health = Health - 1;
            var e=Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(other.gameObject);

            if(Health <= 0)
            {
                Destroy(gameObject);
            }
        }
      
    }
}
