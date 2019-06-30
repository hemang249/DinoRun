using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandScript : MonoBehaviour
{

    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveAhead();
    }

    void MoveAhead()
    {
        Vector3 xAxis = new Vector3(-1f,0f,0f);
        transform.position += xAxis * moveSpeed * Time.deltaTime;
    }
}
