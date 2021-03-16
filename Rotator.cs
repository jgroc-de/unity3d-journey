using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // variable en public pour pouvoir la modifier directement dans unity
    public float speed = 0.5F;

    void Start() {}

    // Update is called once per frame
    void Update() {
        //fait tourner l'ojbet à la vitesse speed autour de son axe "left". peut etre "up" ou "right"
        transform.Rotate(Vector3.left, speed);
    }
}
