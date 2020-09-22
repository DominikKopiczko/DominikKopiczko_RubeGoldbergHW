using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
   public PhysicsMaterial2D BallBounce2;
   public bool isTriggered;
   void Start(){
      isTriggered = false;
   }
   void OnTriggerEnter2D(Collider2D activator){
       activator.GetComponent<CircleCollider2D>().sharedMaterial = BallBounce2;
       isTriggered = true;
   }
}
