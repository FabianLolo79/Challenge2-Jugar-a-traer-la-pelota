using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    public float leftLimit;
    public float bottomLimit;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x > leftLimit)
        {
            Debug.Log("entró al límite left");
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit - este sí anda
        else if (transform.position.y < bottomLimit)
        {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        }

    }
}
