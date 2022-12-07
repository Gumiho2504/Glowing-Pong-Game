using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    public bool player1Start = true;
    public float startSpeed;
    public float extraSpeed;
    public float maxExtraSpeed;
    private int hitCounter;
    private Rigidbody2D ball;
    // Start is called before the first frame update
    void Start()
    {
        ball = GetComponent<Rigidbody2D>();
        StartCoroutine(Lauch());
    }
    private void RestartBall()
    {
        ball.velocity = new Vector2(0, 0);
        transform.position = new Vector2(0, 0);
    }
    public IEnumerator Lauch()
    {
        RestartBall();
        hitCounter = 0;
        yield return new WaitForSeconds(1);
        if(player1Start == true)
        {
             Moveball(new Vector2(-1, 0));
        }
        else
        {
            Moveball(new Vector2(1, 0));
        }
      
    }
    public void Moveball(Vector2 direction)
    {
        direction = direction.normalized;
        float ballSpeed = startSpeed  +  hitCounter + extraSpeed;
        ball.velocity = direction * ballSpeed;

    }
    public void IncreaseHitConter()
    {
        if (hitCounter *extraSpeed < maxExtraSpeed)
        {
            hitCounter++;
        }
    }
    // Update is called once per frame
   
}
