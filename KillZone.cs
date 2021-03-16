using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    public GameObject positionDepart;
    public GameObject player;

    void Start() {}

    void Update() {}

    public void OnTriggerEnter(Collider thing) { 
        if (thing.tag == "Player") {
            //si le tag du machin qui est entré en collision avec la killzone est player
            //alors on modifie la position du machin pour quelle soit identique à celle d'un autre truc fixe
            thing.transform.position = positionDepart.transform.position;
        }
    }
}
