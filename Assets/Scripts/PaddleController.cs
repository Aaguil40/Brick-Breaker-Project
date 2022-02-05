using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float playerInput;
    public float paddleSpeed;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        playerInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * paddleSpeed * playerInput);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Extend Paddle"))
        {
            GetComponent<Transform>().localScale = new Vector2(4, .3f);
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Speed Up"))
        {
            paddleSpeed = 20;
            Destroy(other.gameObject);
        }
    }
}
