using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominicsPlayerController : MonoBehaviour
{
    public float movespeed = 5f;
    public float jumpForce = 15f;

    private Rigidbody2D _rigidbody2D;
    private CapsuleCollider2D _capsuleCollider2D;
    private Animator _animator;
    private DominicMagnetBeam _magnetBeam;
    private Transform _magnetParent;

    // Start is called before the first frame update
    void Start()
    {
        _capsuleCollider2D = GetComponent<CapsuleCollider2D>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponentInChildren<Animator>();
        _magnetBeam = GameObject.Find("Magnet Beam").GetComponent<DominicMagnetBeam>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        PlayerInMagnet();
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        _animator.SetFloat("movementValue", horizontalInput);

        _rigidbody2D.velocity = new Vector2(horizontalInput * movespeed, _rigidbody2D.velocity.y);
    }

    private void PlayerInMagnet()
    {
        if(_magnetBeam.IsBeamActive())
        {
            _animator.SetBool("IsMagnetActive", _magnetBeam.IsBeamActive());
            StartCoroutine("PlayerGoingUp");
        }
        else
        {
            _animator.SetBool("IsMagnetActive", _magnetBeam.IsBeamActive());
            _animator.SetBool("InBeam", false);
        }
    }

    IEnumerator PlayerGoingUp()
    {
        yield return new WaitForSeconds(1.2f);
        _animator.SetBool("InBeam", true);
    }

    public void SetMagnetParent()
    {
        //_magnetParent
    }
}
