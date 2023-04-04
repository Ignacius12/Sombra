using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Audio;

public class ActivadorPuerta : MonoBehaviour
{
    public AudioSource quienEmite;
    public PlayableDirector director;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            director.Play();
            quienEmite.Play();
        }
    }
}
