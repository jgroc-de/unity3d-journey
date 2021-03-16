using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Chrono : MonoBehaviour
{
    // temps restant
    public float chrono = 60;

    // temps restant en nombre entier (int pour integer)
    private int intChrono = 0;

    // variable pour l'objet text qui sera affiché pour le joueur
    public Text textArea;

    // Start is called before the first frame update
    void Start() {
        // on appelle UpdateTime pour afficher le temps restant
        this.UpdateTime();
    }

    // Update is called once per frame
    void Update() {
        // on appelle UpdateTime pour mettre à jour temps restant
        this.UpdateTime();
        this.chrono -= Time.deltaTime;
        if (this.chrono <= 0) {
            // si le temps est écoulé, on charge la scene de game over
            SceneManager.LoadScene("gameOver", LoadSceneMode.Single);
        }
    }

    void UpdateTime() {
        // test pour voir si on change de seconde pour éviter de spammer le jeu de modif de texte toutes les 2 ms…
        if ((int)chrono != this.intChrono) {
            // si on change de seconde, on maj le text affiché.
            this.intChrono = (int)chrono;
            this.textArea.text = "Time remaining: " + this.intChrono.ToString() + "s";
        }
    }
}
