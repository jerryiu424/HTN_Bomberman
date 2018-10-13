using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombInGame : MonoBehaviour {

    public float countdown = 2f;
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;

        if(countdown <= 0f)
        {
            Debug.Log("DAMBLOL");
            Destroy(gameObject);
        }
	}
}
