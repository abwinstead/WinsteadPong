using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPong : MonoBehaviour
{
 
    float speed;
    float height;

    string input;
    public bool isRight;


    // Start is called before the first frame update
    void Start()
    {
        height = transform.localScale.y;
        speed = 10f;
    }


    public void Init(bool isRightPingPong)
    {
        isRight = isRightPingPong;
        Vector2 pos = Vector2.zero;

        if (isRightPingPong)
        {
            //Paddle on right side
            pos = new Vector2(Management.topRight.x, 0);
            pos -= Vector2.right * transform.localScale.x;
            input = "RightPingPong";
        }
        else
        {
            //Paddle on left side
            pos = new Vector2(Management.bottomLeft.x, 0);
            pos += Vector2.right * transform.localScale.x;
            input = "LeftPingPong";
        }

        transform.position = pos;
    }
    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis(input) * Time.deltaTime * speed;

        if (transform.position.y < Management.bottomLeft.y + height / 2 && move < 0)
        {
            move = 0;
        }
        if (transform.position.y > Management.topRight.y - height / 2 && move > 0)
        {
            move = 0;
        }

        transform.Translate(move * Vector2.up);
    }
}
