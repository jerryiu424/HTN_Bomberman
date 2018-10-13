using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speedx = 1.0f;
    public float speedy = 1.0f;
    public Rigidbody bomb;

    Rigidbody2D rb;
    CircleCollider2D cc;

    void Awake()
    {
        //Get references to our components
        rb = GetComponent<Rigidbody2D>();
        cc = GetComponent<CircleCollider2D>();
    }

    // Use this for initialization
    void Start () {
		
	}

    void PlaceBomb()
    {
        Rigidbody bombClone = (Rigidbody)Instantiate(bomb, transform.position, transform.rotation);

    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speedx, Input.GetAxis("Vertical") * speedy);
        if (Input.GetButtonDown("right") || Input.GetButtonDown("left") || Input.GetButtonDown("A") || Input.GetButtonDown("D"))
        {
            speedx += 1;
        }
        if (Input.GetButtonDown("up") || Input.GetButtonDown("down") || Input.GetButtonDown("W") || Input.GetButtonDown("S"))
        {
            speedy += 1;
        }

        if (Input.GetButtonDown("Space"))
        {
            PlaceBomb();
        }
    }
}
