using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownTranslator : MonoBehaviour
{
    //vitesse brut
    public float speed = 1;

    //variable pour modifier le sens de la vitesse
    private float currentSpeed = 0;

    // hauteur min de la plateforme
    public float minHeight = 1;

    // hauteur max de le plateforme
    public float maxHeight = 4;

    // Start is called before the first frame update
    void Start() {
        //on démarre vitesse vers le bas
        this.currentSpeed = -speed;
    }

    // Update is called once per frame
    void Update() {
        if (this.transform.position.y < minHeight) {
            // si on passe sous le point bas, on remonte
            this.currentSpeed = this.speed;
        } else if (this.transform.position.y > maxHeight) {
            // si on passe au dessus du point bas, on descend
            this.currentSpeed = -this.speed;            
        }
        // translate l'objet à la vitesse demandée
        transform.Translate(0, this.currentSpeed, 0);
    }
}
