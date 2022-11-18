using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    public GameObject enemy;
    private int counter = 1;
    public int spheres = 1;
    //Screen limits
    private float xLim = 9;
    private float yLim = 4.5f;
 
    void Update()
    {
        //If we eliminated all spheres, the next round starts, with one more sphere than the previous one
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
    //Screen limits where the spheres can spawn
    private Vector3 SpawnPosition()
    {
        return new Vector3(Random.Range(-xLim, xLim), Random.Range(-yLim, yLim), 0);
    }
}
