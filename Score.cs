using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //compteur de coins
    public int coins = 0;

    //objet gerant l'affichage du score
    public Text textArea;

    // Start is called before the first frame update
    void Start() {
        this.UpdateScore();
    }

    void Update() {}

    public void AddCoin() {
        this.coins += 1;
        this.UpdateScore();
        if (this.coins == 12) {
            //si on a récupérer toutes les pieces (la je sais que j'en ai mis 12 dans le jeu)
            //on change de scene
            SceneManager.LoadScene("victory", LoadSceneMode.Single);
        }
    }

    public void UpdateScore() {
        //affiche le score
        this.textArea.text = "Score: " + coins.ToString() + " / 12";
    }
}
