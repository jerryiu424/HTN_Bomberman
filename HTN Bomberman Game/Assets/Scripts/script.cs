using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

    public float speedx = 1.0f;
    public float speedy = 1.0f;
    public GameObject bomb;

    Rigidbody2D rb;
    CircleCollider2D cc;

    void PlaceBomb()
    {

        Instantiate (bomb,transform.position,Quaternion.identity);
        //GameObject bombClone = (GameObject)Instantiate(bomb, transform.position, transform.rotation);
        //bombClone.velocity = transform.forward * speed;
        // Use this ^, if we want to be able to push the bomb forward.  

        // You can also access other components / scripts of the clone
        // rocketClone.GetComponent<MyRocketScript>().DoSomething();
    }

    void Awake()
    {
        //Get references to our components
        rb = GetComponent<Rigidbody2D>();
        cc = GetComponent<CircleCollider2D>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speedx, Input.GetAxis("Vertical") * speedy);

        //if (Input.GetButtonDown("Horizontal"))
        //{
        //    speedx += 1;
        //    transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
        //}
        if (Input.GetButtonDown("Left"))
        {
            speedx += 1;
            transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);
        }

        if (Input.GetButtonDown("Right"))
        {
            speedx += 1;
            transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);
        }

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("The FUCK?");
            PlaceBomb();
        }
    }
}
