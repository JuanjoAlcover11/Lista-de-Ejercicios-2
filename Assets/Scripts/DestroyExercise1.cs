using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExercise1 : MonoBehaviour
{
    private Exercise1 exercise1;
    void Start()
    {
        exercise1 = FindObjectOfType<Exercise1>();
    }

    private void OnMouseDown()
    {
        exercise1.spheres--;
        Destroy(gameObject);
    }
}
