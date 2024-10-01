using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float maxX = 7.5f;
    float movementHorizontal;
    
    // Update is called once per frame
    void Update()
    {
        movementHorizontal = Input.GetAxisRaw("Horizontal");
        if((movementHorizontal > 0 && transform.position.x < maxX ) || (movementHorizontal < 0 && transform.position.x > -maxX))
            transform.position += Vector3.right * movementHorizontal * speed * Time.deltaTime;
    }
}
