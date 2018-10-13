using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Follow : MonoBehaviour {

    public GameObject player;
    public float camX;
    public float camY;

    private Vector2 camSpeed;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("penguin");
    }

    private void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref camSpeed.x, camX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref camSpeed.y, camY);

        transform.position = new Vector3(posX, posY, transform.position.z);

    }
}
