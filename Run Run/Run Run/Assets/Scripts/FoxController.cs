using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxController : MonoBehaviour
{ 
    [SerializeField] int Speed;
    private Rigidbody2D rb;
    public float jumpForce = 150;
    public bool isJump;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            if (isJump == false) 
            {
                rb.AddForce(Vector2.up * jumpForce);
                isJump = true;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) 
        {
            isJump = false;
        }
    }
}
