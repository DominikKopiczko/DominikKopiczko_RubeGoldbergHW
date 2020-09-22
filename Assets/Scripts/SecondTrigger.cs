using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondTrigger : MonoBehaviour
{
    public GameObject BallBox;
   void OnTriggerEnter2D(Collider2D activator){
       Destroy(BallBox);
   }
}
