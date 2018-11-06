using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioQueue : MonoBehaviour {

	public AudioClip StartClip;
    public AudioClip[] ClipList = new AudioClip[14];
    AudioSource source;
         
    void Start()
    {
    	source = gameObject.GetComponent<AudioSource>();
        StartCoroutine(playSound(StartClip));
    }
 
    IEnumerator playSound(AudioClip clip)
    {
        source.clip = clip;
        source.Play();

        for(int i = 0; i < 14; i++) {
        	yield return new WaitForSeconds(source.clip.length);
        	source.clip = ClipList[i];
        	source.Play();
        }
    }
}
