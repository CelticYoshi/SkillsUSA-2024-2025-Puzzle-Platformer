using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominicsPlayerController : MonoBehaviour
{
    public float movespeed = 5f;
    public float jumpForce = 15f;

    private Rigidbody2D _rigidbody2D;
    private CapsuleCollider2D _capsuleCollider2D;

    // Start is called before the first frame update
    void Start()
    {
        _capsuleCollider2D = GetComponent<CapsuleCollider2D>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        _rigidbody2D.velocity = new Vector2(horizontalInput * movespeed, _rigidbody2D.velocity.y);
    }
}
