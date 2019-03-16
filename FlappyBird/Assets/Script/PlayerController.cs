using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 600f;
   
    Rigidbody2D _rigidbody;
    private AudioSource audiosource;
    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_rigidbody == null)
            return;
        if (Input.GetMouseButtonDown(0))
        {
            audiosource.Play();
            _rigidbody.velocity = new Vector2(0, speed);
        }
        if (_rigidbody.velocity.y>0)
        {
            transform.eulerAngles = new Vector3(0,0,60f);
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, -60f);
        }
    }
}
