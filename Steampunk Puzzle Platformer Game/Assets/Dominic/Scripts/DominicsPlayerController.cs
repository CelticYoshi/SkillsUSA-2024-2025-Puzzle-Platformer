using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominicsPlayerController : MonoBehaviour
{
    public float movespeed = 5f;
    public float jumpForce = 3f;
    public DominicMagnet _magnet;

    private Rigidbody2D _rigidbody2D;
    private CapsuleCollider2D _capsuleCollider2D;
    private Animator _animator;
    private DominicMagnetBeam _magnetBeam;
    private Transform _magnetParent;
    [SerializeField] private bool _isInMagnet;

    // Start is called before the first frame update
    void Start()
    {
        _capsuleCollider2D = GetComponent<CapsuleCollider2D>();
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponentInChildren<Animator>();
        _magnetBeam = GameObject.Find("Magnet Beam").GetComponent<DominicMagnetBeam>();
        _magnet = GameObject.Find("Magnet").GetComponent<DominicMagnet>();
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

    IEnumerator PlayerGoingUp()
    {
        yield return new WaitForSeconds(1.2f);
        _animator.SetBool("InBeam", true);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Magnet"))
            {
                //new WaitForSeconds (1.2f);
                _isInMagnet = true;
                StartCoroutine("PlayerInMagnet");
            }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Magnet"))
            {
                _isInMagnet = false;
                _animator.SetBool("IsMagnetActive", false);
            }
    }

    void PlayerInMagnet()
    {
        if (_isInMagnet)
        {
            new WaitForSeconds (1.2f);
            _animator.SetBool("IsMagnetActive", true);
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
        }
    }
}
