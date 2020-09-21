
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
   public Transform player;
   public Vector3 offset;//stores 3 floats (x,y,z)

    // Update is called once per frame
    void Update() {
        //+ adding two vectors here!
        transform.position = player.position + offset;
        
    }
}
