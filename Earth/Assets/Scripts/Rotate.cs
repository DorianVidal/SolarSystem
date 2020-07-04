using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speedRotate;
    public GameObject sun;

    public float angle;

    private void Update()
    {
        //Tourne autour du soleil
        transform.RotateAround(sun.transform.position, sun.transform.up, speedRotate * Time.deltaTime);

        //Tourne sur Lui même
        transform.Rotate(0, angle , 0);
    }
}
