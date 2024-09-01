using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float moveBoost = 30f;
    [SerializeField] float moveSlow = 10f;
    
    [SerializeField] float steerSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        //transform.Rotate(0, 0, 45);
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed* Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed* Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
     moveSpeed = moveSlow;   
    }

     void OnTriggerEnter2D(Collider2D other) 
    {
      if (other.tag == "Boost") 
      {
        moveSpeed = moveBoost;
      }   
      
    }
}
