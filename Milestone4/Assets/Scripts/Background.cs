using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {



    public float Xe;
    public float Xs;
    public float speedChosen;

    private void Update()
    {
        transform.Translate(Vector2.left * speedChosen * Time.deltaTime);
        if (transform.position.x < Xe) {
            Vector2 pos = new Vector2(Xs, transform.position.y);
            transform.position = pos;
        } 
    }
}
