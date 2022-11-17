using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    public GameObject enemy;
    private int counter = 1;
    public int spheres = 1;

    private float xLim = 9;
    private float yLim = 4.5f;
 
    void Update()
    {
        if (spheres == 0)
        {
            counter++;
            spheres = counter;
            for(int i = 0; i < counter; i++)
            {
                Instantiate(enemy, SpawnPosition(), enemy.transform.rotation);
            }
        }
    }

    private Vector3 SpawnPosition()
    {
        return new Vector3(Random.Range(-xLim, xLim), Random.Range(-yLim, yLim), 0);
    }
}
