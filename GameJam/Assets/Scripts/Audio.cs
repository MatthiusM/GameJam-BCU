using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Audio : MonoBehaviour
{
    [Serializable]
    public class audioFile
    {
        public string name;
        public AudioClip clip;
    }

    public audioFile[] audioSources;
    

    private Dictionary<string, AudioClip> audioDict = new();

    private AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        foreach (var audioSource in audioSources)
        {
            audioDict.Add(audioSource.name, audioSource.clip);
        }
    }

    public void PlaySound(string audioName)
    {        
        audioDict.TryGetValue(audioName, out AudioClip audioClip);
        if(!audioClip) { return; }
        source.clip = audioClip;
        source.Play();
    }

    public void PlayBackroundMusic(string audioName)
    {
        audioDict.TryGetValue(audioName, out AudioClip audioClip);
        if (!audioClip) { return; }
        source.clip = audioClip;
        source.loop = true;
        source.Play();
    }

    public void StopSound(string audioName)
    {
        audioDict.TryGetValue(audioName, out AudioClip audioClip);
        if (!audioClip) { return; }
        source.Stop();
    }

    public void StopBackroundMusic(string audioName)
    {
        audioDict.TryGetValue(audioName, out AudioClip audioClip);
        if (!audioClip) { return; }
        source.loop = false;
        source.Stop();
    }
}
