using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;
    public float minY;
    public float maxY;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Check if we are left or right paddle
        //Move the paddle
        if (gameObject.name == "rightPaddle")
        {
            MovePaddle(gameObject.name);
        }
        else if (gameObject.name == "leftPaddle")
        {
            MovePaddle(gameObject.name);
        }
    } 
    // Update

    void MovePaddle(string paddleName)
    {
        float moveY = Input.GetAxisRaw(paddleName) * speed * Time.deltaTime;

        transform.position = new Vector2(
            transform.position.x,
           Mathf.Clamp(transform.position.y + moveY,minY,maxY) );
    }

}
// Class