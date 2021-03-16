using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideThingAtStart : MonoBehaviour
{
    public GameObject thing;

    // Start is called before the first frame update
    void Start() {
        //desactive l'objet à l'initialisation du jeu
        thing.SetActive(false);
    }

    void Update() {}
}
