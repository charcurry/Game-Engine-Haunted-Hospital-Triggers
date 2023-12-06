using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Trigger : MonoBehaviour
{

    public PlayableDirector timeLine;
    public bool oneTimeTimeline = true;

    private void OnTriggerEnter(Collider other)
    {
        timeLine.Play();
        if (oneTimeTimeline)
        {
            Destroy(gameObject);
        }
    }
}
