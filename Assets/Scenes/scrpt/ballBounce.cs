using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBounce : MonoBehaviour
{
    public GameObject hitSound;
    public ballMovement BallMovement;
    public scoreManager Score;
    private void Bounce(Collision2D collision)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;
        float postionX;

        if(collision.gameObject.name == "player1")
        {
            postionX = 1;
        }else
        {
            postionX = -1;
        }
        float postionY = (ballPosition.y - racketPosition.y) / racketHeight;
        BallMovement.IncreaseHitConter();
        BallMovement.Moveball(new Vector2(postionX, postionY));
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player1" || collision.gameObject.name == "player2")
        {
            Bounce(collision);
        } else if (collision.gameObject.name == "left")
        {
            Score.player2Goal();
            BallMovement.player1Start = false;
            StartCoroutine(BallMovement.Lauch());
        }
        else if (collision.gameObject.name == "right")
        {
            Score.player1Goal();
            BallMovement.player1Start = true;
            StartCoroutine(BallMovement.Lauch());
        }
        Instantiate(hitSound,transform.position,transform.rotation);
    }
}
