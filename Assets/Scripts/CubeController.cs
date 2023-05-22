using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CubeController : MonoBehaviour
{
   public IntValue MonsterHp;
   public SubNewsletter MonsterDeathNewsletter;
   public SubNewsletter MonsterHitNewsletter;
   private Animator _anim;
   [SerializeField] private GameObject _monster;
   [SerializeField] private GameObject _death;
   [SerializeField] private GameObject _blood;
   
   public void Awake()
   {
      _anim = GetComponent<Animator>();
     
   }

   private void OnMouseDown()
   {
      Hit();
      MonsterHitNewsletter.SendNewsletter();
      if (MonsterHp.value < 0)
      {
         MonsterDeathNewsletter.SendNewsletter();
         Dead();
      }
      
   }
   private void OnMouseUp()
   {
      Stop();
   }

   private void Hit()
   {
     MonsterHp.value -= 10;
     _anim.SetBool("isHit", true);
     Debug.Log("pain");
     _blood.SetActive(true);
   }

   private void Stop()
   {
      _anim.SetBool("isHit", false);
      _blood.SetActive(false);
   }

   private void Dead()
   {
      Debug.Log("dętka");
      _death.SetActive(true);
      Destroy(_monster);
   }

}
