using UnityEngine;

[System.Serializable]
public class Music
{
    /// <summary>
    /// This class is used as a base for the audio manager
    /// </summary>
    public string name;

    public AudioClip source;

    [Range(0f,1f)]
    public float volume;
    [Range(0.0f,2f)]
    public float pitch;

    public bool loop;

    [HideInInspector]
    public AudioSource audioSource;
   
  
}

