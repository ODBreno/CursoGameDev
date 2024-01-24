using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float runspeed = 2f;

    private bool _isRunning;
    private bool _isRolling;

    private Rigidbody2D rb;
    private Vector2 _direction;
    public float initialSpeed;
    public Vector2 direction
    {
        get { return _direction; }
        set { _direction = value; }
    }

    public bool isRunning
    {
        get { return _isRunning; }
        set { _isRunning = value; }
    }

    public bool isRolling
    {
        get { return _isRolling; }
        set { _isRolling = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _direction = Vector2.zero;
        initialSpeed = speed;
    }

    // Update is called once per frame
    private void Update()
    {
        onInput();

        onRun();
    }

    private void FixedUpdate()
    {
        // For physics
        OnMove();
    }

    #region Movement
    void onInput()
    {
        _direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    void OnMove()
    {
        if (!isRunning)
        {
            speed = initialSpeed;
        }
        rb.MovePosition((Vector2)transform.position + (_direction * speed * Time.deltaTime));
    }

    void onRun()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = runspeed;
            isRunning = true;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = initialSpeed;
            isRunning = false;
        }
    }

    void OnRoll(InputValue inputValue)
    {
        if(inputValue.isPressed)
        {
            speed = runspeed;
            isRolling = true;
        }
        
    }

    #endregion
}
