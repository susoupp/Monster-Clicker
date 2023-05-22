using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
   public IntValue MonsterHp;
   public SubNewsletter playerDeathNewsletter;
   private void OnMouseDown()
   {
      MonsterHp.value -= 10;
      if (MonsterHp.value < 0)
      {
         playerDeathNewsletter.SendNewsletter();
      }
   }


}
