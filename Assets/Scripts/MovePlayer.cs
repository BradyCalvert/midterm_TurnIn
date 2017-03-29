using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

  public Animator anim;
    const string go_left = "go_left";
    const string go_right = "go_right";
    const string go_dle = "go_idle";
 
  const string player_right = "Player_Right";
    const string player_left = "Player_Left";
    const string player_idle = "Player_Idle";


  public float speed;

  public  void Start()
  {

  }
  // Update is called once per frame
  void Update()
  {

      if (Input.GetKeyDown(KeyCode.D) && anim.GetCurrentAnimatorStateInfo(0).IsName(player_right) == false)
      {
        anim.SetTrigger(go_right);
      }

      if (Input.GetKey(KeyCode.D))
      {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
      }

      if (Input.GetKeyDown(KeyCode.A) && anim.GetCurrentAnimatorStateInfo(0).IsName(player_left) == false)
      {
        anim.SetTrigger(go_left);
      }

      if (Input.GetKey(KeyCode.A))
      {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
      }
      if (Input.GetKeyDown(KeyCode.W))
      {
        anim.SetTrigger(go_dle);
      }
      if (Input.GetKey(KeyCode.K))
      {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
      }
      if (Input.GetKey(KeyCode.S))
      {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
      }
      if (Input.GetKeyDown(KeyCode.I))
      {
        anim.SetTrigger(go_dle);
      }  
  }
}
