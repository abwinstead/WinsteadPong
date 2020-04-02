using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Management : MonoBehaviour
{
    public ElBall elBall;
    public PingPong PingPong;

    public static Vector2 bottomLeft;
    public static Vector2 topRight;

    // Start is called before the first frame update
    void Start()
    {
        //making coords line up between pixel and game
        bottomLeft = Camera.main.ScreenToWorldPoint(new Vector2 (0, 0));
        topRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        //making the ball
        Instantiate(elBall);

        //making two different paddles
        PingPong PingPong1 = Instantiate(PingPong) as PingPong;
        PingPong PingPong2 = Instantiate(PingPong) as PingPong;

        //making the left and the right paddle
        PingPong1.Init(true); //right
        PingPong2.Init(false); //left 
    }


}
