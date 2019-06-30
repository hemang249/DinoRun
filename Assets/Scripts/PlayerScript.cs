using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float jumpHeight = 5f;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
     
        Jump();        
    }

    
    void Jump()
    {
        if(Input.touchCount > 0)
        {
            rb.velocity = Vector3.up * jumpHeight * Time.deltaTime;
        }
    }
}
