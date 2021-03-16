using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePlateform : MonoBehaviour
{
    // temps de disparation de la plateforme
    public float time = 5;

    //temps avant le prochain switch
    private float remaining_time = 0;

    //booléen de switch
    private bool isHidden = false;

    // plateform cible
    public GameObject plateform;

    // Start is called before the first frame update
    void Start() {
        // initialisation
        this.remaining_time = this.time;
    }

    // Update is called once per frame
    void Update() {
        if (this.remaining_time <= 0) {
            //si le temps est écoulé, je relance un timer, j'inverse le boolean et modifie le setActive de la plateforme
            this.remaining_time = this.time;
            this.isHidden = !this.isHidden;
            plateform.SetActive(this.isHidden);
        }
        this.remaining_time -= Time.deltaTime;
    }
}
