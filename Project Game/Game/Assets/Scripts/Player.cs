using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10;
    public Rigidbody2D rb;
    private float xInput, yInput;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(xInput, yInput).normalized * speed * Time.fixedDeltaTime;

    }

}
