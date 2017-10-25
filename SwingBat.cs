using UnityEngine;
using System.Collections;

public class SwingBat : MonoBehaviour {

  private int r = 9; // Rotation Speed
  private int r_sum = 0;
  private int r_max = 360;

  // Use this for initialization
  void Start () {
  
  }
  
  // Update is called once per frame
  void Update () {
    if (Input.GetMouseButton(0) && r_sum < r_max) { // Pressed left click
      transform.Rotate(0, -r, 0);
      r_sum += r;
    } else if (!Input.GetMouseButton(0) && r_sum != 0) {
      transform.Rotate(0, r, 0);
      r_sum -= r;
    }
          
  }
}
