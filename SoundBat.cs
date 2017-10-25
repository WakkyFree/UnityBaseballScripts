using UnityEngine;
using System.Collections;

public class SoundBat : MonoBehaviour {

  private AudioSource audioSourceBat;
  public AudioClip seBat;

	// Use this for initialization
	void Start () {
    audioSourceBat = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.name == "Ball") {
      audioSourceBat.PlayOneShot(seBat);
    }
  }

}
