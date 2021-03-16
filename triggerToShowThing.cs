using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class triggerToShowThing : MonoBehaviour
{
    public GameObject plateform;

    public void Start() {}

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            //si le machin qui entre en collision avec cet objet est le player, alors on active le truc relié
            plateform.SetActive(true);
        }
    }
}