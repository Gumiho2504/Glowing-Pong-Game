using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public float racketSpeed;
    private Rigidbody2D play1;
    private Vector2 racketDirection;
    // Start is called before the first frame update
    void Start()
    {
        play1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical2");
        racketDirection = new Vector2(0, directionY).normalized;
    }
    private void FixedUpdate()
    {
        play1.velocity = racketDirection * racketSpeed;
    }
}
