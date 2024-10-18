using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEntity : MonoBehaviour {


    [SerializeField] AudioSource audioSource;

    [SerializeField] AudioClip clip;

    public int id;


    public void Ctor() {
        SetClip();
    }

    public void SetClip() {
        audioSource.loop = true;
        audioSource.clip = clip;
        audioSource.Play();
    }

    public void TearDown() {
        GameObject.Destroy(gameObject);
    }

}
