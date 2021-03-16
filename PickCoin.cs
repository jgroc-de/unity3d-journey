using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickCoin : MonoBehaviour
{
    // objet qui gere le score
    public Score score;

    // la piece qu'on ramasse
    public GameObject coin;

    void Start() {}

    void Update() {}
 
    public void OnTriggerEnter(Collider thing) {
        //on désactive la piece
        coin.SetActive(false);
        //on maj le score
        score.AddCoin();
    }
}
