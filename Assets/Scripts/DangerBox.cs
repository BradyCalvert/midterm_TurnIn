using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerBox : MonoBehaviour {
  public GameObject box;


	// Use this for initialization
	void Start () {
    gameObject.GetComponent<Rigidbody>().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {

		
	}
  public void OnTriggerEnter(Collider other)
  {
    if(other.gameObject.CompareTag("Player"))
    {
      //Invoke("DropBox", 1f);
      StartCoroutine("DropBox");
      
      gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
  }
  IEnumerator DropBox()
  {
    //gameObject.GetComponent<Rigidbody>().useGravity = true;
    yield return new WaitForSeconds( 3f);
    gameObject.GetComponent<Rigidbody>().useGravity = true;
  }
}
