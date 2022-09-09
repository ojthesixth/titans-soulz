using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_mouvement : MonoBehaviour
{
    private float playerMove;
    public float _speed = 10f;
    public GameObject player;
    public Rigidbody2D _rigidbody;
    public BoxCollider2D _collider2D;

    public Vector3 direction;


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
        _rigidbody.velocity = new Vector3(playerMove * _speed, _rigidbody.velocity.y);
        */
        
        float v = Input.GetAxis("Vertical") * _speed;
        float r = Input.GetAxis("Horizontal") * _speed;
        _rigidbody.velocity = new Vector3(r, 0, v);
        
        
    }
}
