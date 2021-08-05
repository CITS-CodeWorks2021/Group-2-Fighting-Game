using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public string hAxis, vAxis;
    Rigidbody2D myRigidbody;
    Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(
        //speed * Input.GetAxis(hAxis) * Time.deltaTime,
        //speed * Input.GetAxis(vAxis) * Time.deltaTime,
        //0);
        Vector2 Moveamount = Vector2.zero;
        Moveamount.x = speed * Input.GetAxis(hAxis) * Time.deltaTime;
        Moveamount.y = speed * Input.GetAxis(vAxis) * Time.deltaTime;
        myRigidbody.AddForce(Moveamount);

        Vector2 velocity = myRigidbody.velocity;
        if (Mathf.Abs(Input.GetAxis(hAxis)) < 0.1f)
        {
            if (Mathf.Abs(velocity.x) < 0.1f) velocity.x = 0;
            velocity.x *= 0.5f;
        }
        if (Mathf.Abs(Input.GetAxis(vAxis)) < 0.1f)
        {
            if (Mathf.Abs(velocity.y) < 0.1f) velocity.y = 0;
            velocity.y *= 0.5f;
        }
        myRigidbody.velocity = velocity;
        myAnimator.SetFloat("Speed", myRigidbody.velocity.magnitude);
        if (velocity.x < 0) GetComponent<SpriteRenderer>().flipX = true;
        else if (velocity.x > 0.1f) GetComponent<SpriteRenderer>().flipX = false;
    }
}
