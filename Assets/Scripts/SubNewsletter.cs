using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SubNewsletter : ScriptableObject
{
    private List<INewsletterSubscriber> _subscribers = new List<INewsletterSubscriber>();

    public void SendNewsletter()
    {
        for (int i = 0; i < _subscribers.Count; i++)
        {
            _subscribers[i].Notify();
        }
    }
    public void SubsrcribeForNewsletter(INewsletterSubscriber newSubscriber)
    {
       _subscribers.Add(newSubscriber);
    }
    
    public void UnsubscribeForNewsletter(INewsletterSubscriber SubscriberToRemove)
    {
        _subscribers.Remove(SubscriberToRemove);
    }
}
