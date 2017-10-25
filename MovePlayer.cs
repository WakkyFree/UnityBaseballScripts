using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {

  private bool d_positive;
  private float x;
  private float x_sum = 0.0f;
  private float x_max = 6.0f;
  private float player_x;
  private float player_y;
  private float player_z;

  // Use this for initialization
  void Start () {
    Vector3 player = GameObject.Find(transform.name).transform.position;
    player_x = player.x;
    player_y = player.y;
    player_z = player.z;

    d_positive = Random.Range(0,2) == 0;
    x = Random.Range(0.1f,0.2f);
  }
  
  // Update is called once per frame
  void Update () {

    if (d_positive && Mathf.Abs(x_sum) < x_max) { // Move positive direction
      transform.position = new Vector3(player_x + x_sum, player_y, player_z);
      x_sum += x;
    } else if (!d_positive && Mathf.Abs(x_sum) < x_max) { // Move negative direction
      transform.position = new Vector3(player_x + x_sum, player_y, player_z);
      x_sum -= x;
    } else {

      if(d_positive){
        x_sum -= x;
      } else {
        x_sum += x;
      }
      d_positive = !d_positive;

    }
          
  }
}
