using UnityEngine;
using System.Collections;

public class WallEffect : MonoBehaviour {

  private ParticleSystem particle;
  public int i;

	// Use this for initialization
	void Start () {
        particle = this.GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  void OnCollisionEnter(Collision collision) {
//    if (collision.gameObject.tag == "Ball") {
      particle.Play();
//    }
  }

}
