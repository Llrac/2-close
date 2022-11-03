using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSoundPlayer : MonoBehaviour
{
    public AudioClip pusselSounds;
    AudioSource audioSource;
        private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            audioSource.PlayOneShot(pusselSounds, 1);
        }
    }
}
