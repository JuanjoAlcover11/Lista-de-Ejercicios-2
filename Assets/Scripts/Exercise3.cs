using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    private Vector3 position;
    private float xLim = 3f;
    private float yLim = 3f;
    private float distance = 1.5f;

    void Update()
    {
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
