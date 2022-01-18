using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    private AudioSource win;
    void Start() {
        win = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Player") {
            win.Play();
        }
    }
}
