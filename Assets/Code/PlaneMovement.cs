using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public float PlaneSpeed = 25f;
    
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       
        float VerticalMovement = Input.GetAxis("Vertical");
        float HorizontalMovement = Input.GetAxis("Horizontal");


       Vector2 velocidad = new Vector2(HorizontalMovement, VerticalMovement).normalized * PlaneSpeed;
        rb.velocity = velocidad;

       
    }
    
}
