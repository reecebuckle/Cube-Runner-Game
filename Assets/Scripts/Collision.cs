using UnityEngine;

public class Collision : MonoBehaviour {

    public PlayerMovement movement;
    // Start is called before the first frame update
    void onCollisionEnter(Collision info) {
        //prints to log what we have collided with
        if (info.GetComponent<Collider>().tag == "Obstacle") {
            Debug.Log("We hit an obstacle!");
            //stop moving if hit an object
            movement.enabled = false;
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
