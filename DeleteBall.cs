using UnityEngine;
using System.Collections;

public class DeleteBall : MonoBehaviour {

  private Rigidbody rig;

  // Use this for initialization
  void Start () {
    rig = this.GetComponent<Rigidbody>();
  }
  
  // Update is called once per frame
  void Update () {

  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag != "Ground" & collision.gameObject.tag != "Bat") {
      //Destroy(gameObject);
      rig.velocity = Vector3.zero; 
      rig.angularVelocity = Vector3.zero;
      transform.position = new Vector3(0, 1.5f, -5.8f);
      ShootBall.shootSwitch = true;    
    }
  }
}
