using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    //Position of the circle
    private Vector3 position;
    //Screen limits
    private float xLim = 3f;
    private float yLim = 3f;
    //Distance the circle moves
    private float distance = 1.5f;

    void Update()
    {
        //Depending on the key pressed, the circle will move on a different direction
        //It depends of the position (x,y,z) and if its positive or negative. Then we make it go straight with the rotation
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y != yLim)
        {
            position = new Vector3(transform.position.x, transform.position.y + distance, transform.position.z);
            transform.position = position;
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x != xLim)
        {
            position = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);
            transform.position = position;
            transform.rotation = Quaternion.Euler(0, 0, -180);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y != -yLim)
        {
            position = new Vector3(transform.position.x, transform.position.y - distance, transform.position.z);
            transform.position = position;
            transform.rotation = Quaternion.Euler(0, 0, -270);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x != -xLim)
        {
            position = new Vector3(transform.position.x - distance, transform.position.y, transform.position.z);
            transform.position = position;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
