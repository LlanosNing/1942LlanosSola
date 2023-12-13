using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float PlaneSpeed = 25f;
    public string VerticalAxis;
    public string HorizontalAxis;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       
        float VerticalMovement = Input.GetAxis(VerticalAxis);
        rb.velocity = new Vector2(0f, VerticalMovement) * PlaneSpeed;

        float HorizontalMovement = Input.GetAxis(HorizontalAxis);
        rb.velocity = new Vector2(HorizontalMovement, 0f) * PlaneSpeed;
    }
    
}
