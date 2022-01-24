using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public bool balllaunched = false;
    public Rigidbody2D ballRigidbody;
    public Vector2[] startDirections;
    public int randomNumber;
    public float ballForce;
    public Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !balllaunched)
        {
            randomNumber = Random.Range(0, startDirections.Length);
            ballRigidbody.AddForce(startDirections[randomNumber] * ballForce, ForceMode2D.Impulse);
            balllaunched = false;
        }
    }
}
