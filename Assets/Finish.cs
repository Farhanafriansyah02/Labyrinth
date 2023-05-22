using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Finish : MonoBehaviour
{
    public UnityEvent OnBallEnter = new UnityEvent();

    private void OnCollisionEnter(Collision other) {
        OnTriggerEnter(other.collider);
    }
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Ball"))
        {
            OnBallEnter.Invoke();            
        }
    }
}