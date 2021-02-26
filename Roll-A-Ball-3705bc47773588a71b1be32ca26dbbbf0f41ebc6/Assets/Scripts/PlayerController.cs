using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;
    private int score = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        if (score >= 8)
        {
            print("You Win!");
        }
    }
    private void OnTriggerEnter(Collider otherObject)
    {
        if(otherObject.tag == "Pick Up")
        {
            print("PickedUp");
            Destroy(otherObject.gameObject);
            score += 1;
            print("Score = " + score);
        }
    }
}
