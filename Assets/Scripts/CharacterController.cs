using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterController : MonoBehaviour {

    public float maxSpeed = 10f;
    private bool facingRight = true;
    public Rigidbody2D rb2d;
	void Start () {
		
	}
	
	
	void FixedUpdate () {
        float move = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(move * maxSpeed, rb2d.velocity.y);
        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
	}
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
