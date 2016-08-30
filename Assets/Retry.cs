using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Retry : MonoBehaviour {
  public Transform lose;

  void Update (){
    if ((Input.GetMouseButtonDown(0))) {
      Application.LoadLevel ("snake");
      Application.UnloadLevel ("Lose");
    }
  }

  void Start () {

  }

}
