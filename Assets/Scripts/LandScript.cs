using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandScript : MonoBehaviour
{
    [Header("Land Generation")]
    public GameObject Land;
    public GameObject Camera_Right;
    public GameObject Camera_Left;
    public GameObject LandGenerator;
    public GameObject MidPoint;
    public GameObject EndPoint;
    private bool hasGenerated = false;


    [Space]
    [Header("Land Movement")]
    public float moveSpeed = 5f;
   
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveAhead();
        CheckForLandGeneration();
        CheckForLandDestruction();
    }

    void MoveAhead()
    {
        Vector3 xAxis = new Vector3(-1f,0f,0f);
        transform.position += xAxis * moveSpeed * Time.deltaTime;
    }

    void CheckForLandGeneration()
    {
        if(MidPoint.transform.position.x < Camera_Right.transform.position.x && !hasGenerated)
        {
            GenerateLand();
            hasGenerated = true;
        }
    }

    void CheckForLandDestruction()
    {
        if(EndPoint.transform.position.x < Camera_Left.transform.position.x)
        {
            Destroy(this.gameObject);
        }
    }

    void GenerateLand()
    {
        Instantiate(Land , LandGenerator.transform.position , LandGenerator.transform.rotation);

    }
}
