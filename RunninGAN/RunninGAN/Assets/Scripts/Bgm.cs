using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgm : MonoBehaviour {

	public static AudioClip pulay, ded;
	static AudioSource audioSrc;

	// Use this for initialization
	void Start () {

		pulay = Resources.Load<AudioClip> ("pulay");
		ded = Resources.Load<AudioClip> ("ded");
		audioSrc = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
	}

	public static void PlaySound (string clip)
	{
		switch (clip) {
		case "pulay":
			audioSrc.PlayOneShot (pulay);
			break;
		case "ded":
			audioSrc.PlayOneShot (ded);
			break;
		}
	}
}
