using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_mouvement : MonoBehaviour
{
    private float playerMove;
    public float _speed = 4f;
    public GameObject player;
    public Rigidbody2D _rigidbody;
    //public BoxCollider2D _collider2D; <-was for square placeholder
    public CapsuleCollider2D _collider2D;


    public Vector2 direction;

    //public Vector2 velocity = new Vector2();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        playerMove = Input.GetAxisRaw("Horizontal");
        playerMove = Input.GetAxisRaw("Vertical");
        _rigidbody.velocity = new Vector3(playerMove * _speed, _rigidbody.velocity.y.x);
        */


        float v = Input.GetAxis("Vertical") * _speed;
        float r = Input.GetAxis("Horizontal") * _speed;
        _rigidbody.velocity = new Vector2(r, v);


        /*
        if (Input.GetButton("Horizontal"))
        {
            GameObject.transform.translate(new Vector3(0, 0, 0.01f));
            GameObject.transform.translate(new Vector3(-0.01f, 0, 0));
        }

        AGH!!!

           if (Input.IsActionPressed("right"));
        if (Input.IsActionPressed("left"));
        if (Input.IsActionPressed("down"))
            velocity = new Vector2(-speed, 0);
        if (Input.IsActionPressed("up"))
            velocity = new Vector2(speed, 0);
    }

    public override void _PhysicsProcess(float delta)
    {
        GetInput();
        velocity = MoveAndSlide(velocity);
    }   */

    }
}
