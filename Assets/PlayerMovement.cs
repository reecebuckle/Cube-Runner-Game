
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

public Rigidbody rb;

//variables to handle forwards and sideways force. The 'f' is to identify these are floats
public float forwardForce = 2000f;
public float sidewaysForce = 500f;
//public float jumpHeight = 3f;

//public float distToGround = 0.5f;

    //oid Start() {
    //    rb = GetComponent<Rigidbody> ();
    
    //}

    // Unity prefers fixed update when using physics collisions 
    void FixedUpdate() {
        //add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //If user inputs D on keyboard
        if (Input.GetKey("d")) {
            //apply force on object in postive x direction (to right)
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
         if (Input.GetKey("a")) {
            //move left
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }

       // if (Input.GetKey(KeyCode.Space) && isGrounded()) {
            //Vector3 jumpVelocity = new Vector3 (0f, jumpSpeed, 0f);
            //rb.velocity = rb.velocity + jumpVelocity; 
            //velocity.y = Mathf.Sqrt(jumpHeight * - 2f * gravity);

       // }

        //float horizontalVelocity = Input.GetAxis("Horizontal");
       // float verticalVelocity = Input.GetAxis("Vertical");
        //Vector3 movement = new Vector3 (horizontalVelocity * 10f * Time.deltaTime, 0, verticalVelocity * 10f * Time.deltaTime);
       
    }
     //bool isGrounded () {
      //      return Physics.Raycast (transform.position, Vector3.down, distToGround);
      //  }
       
}
