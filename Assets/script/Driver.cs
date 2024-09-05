using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anton : MonoBehaviour
{
    [SerializeField] float steerSpeed = 5f;
    [SerializeField] float moveSpeed = 8f;
    [SerializeField] float slowSpeed = 4f;
    [SerializeField] float boostSpeed = 10f;  // Disesuaikan untuk kecepatan gerak yang lebih wajar

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Mengambil input horizontal dan vertical
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime   ;

        // Rotasi objek berdasarkan input horizontal
        transform.Rotate(0, 0, -steerAmount);

        // Pergerakan objek dalam arah lokal (forward) berdasarkan input vertical
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed; 
            Debug.Log("Whuuuuuussssshhhhhhh");      
        }
    }
}
