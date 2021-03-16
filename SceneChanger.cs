using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    void Start() {
        //force l'affichage du curseur de la souris
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    void Update() {}

    public void GoToGame() {
        //charge la scene de jeu en mode solo (pas par dessus)
        SceneManager.LoadScene("game", LoadSceneMode.Single);
    }
}
