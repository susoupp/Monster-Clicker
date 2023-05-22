using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using DG.Tweening;

public class CameraShake : MonoBehaviour, INewsletterSubscriber
{
    public SubNewsletter MonsterHitNewsletter;
    [SerializeField] private Transform _camera;
    

  

    private void Update()
    {
        MonsterHitNewsletter.SubsrcribeForNewsletter(this);
    }

    public void Notify()
    {
        _camera.transform.DOShakePosition(0.5f,0.02f, 5);
    }
}
