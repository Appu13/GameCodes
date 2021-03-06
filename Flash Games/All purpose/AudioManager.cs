﻿using System;
using UnityEngine;

public class AudioManager : MonoBehaviour 
{
	/// <summary>
	/// This is used to manage the audio for the scene
	/// </summary>

	public Music[] musics;
    
	void Awake()
    {
		foreach(Music m in musics)
        {
			m.audioSource=gameObject.AddComponent<AudioSource>();
			m.audioSource.clip = m.source;
			
			m.audioSource.volume = m.volume;
			m.audioSource.pitch = m.pitch;
			m.audioSource.loop = m.loop;

        }
    }
	

	

	// Used to play the audio
	public void PlayAudio (string name)
    {
		// Searching for the needed music and storing in variable
		Music m = Array.Find(musics, music => music.name == name);

		if(m==null)
        {
			Debug.LogWarning("Audio " + name + " is missing");
			return;
        }

		m.audioSource.Play();
		
	}

	//Use to adjust the pitch of any one audio
	public void AdjustPitch(float _pitch, string name)
    {
		Music m = Array.Find(musics, music => music.name == name);

		if (m == null)
		{
			Debug.LogWarning("Audio " + name + " is missing");
			return;
		}

	    m.audioSource.pitch = _pitch;
		
    }

    // Used to adjust the volume of any one audio
    public void AdjustVolume(float _vol, string name)
    {
		Music m = Array.Find(musics, music => music.name == name);

		if(m == null)
        {
			Debug.LogWarning("Audio" + name + " is missing");
			return;
        }

		m.audioSource.volume = _vol;
    }

	// Used to stop the audio from playing
	public void StopAudio(string name)
    {
		Music m = Array.Find(musics, music => music.name == name);

		if(m == null)
        {
			Debug.LogWarning("Audio" + name + " is missing");
			return;
        }

		m.audioSource.Stop();
    }
}
