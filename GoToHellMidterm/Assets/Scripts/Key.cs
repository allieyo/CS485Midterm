using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    public bool hasKey = false;
    public UnityEngine.Events.UnityEvent PlatformsToMove;

    private void OnTriggerEnter2D(Collider2D other)
    {

        hasKey = true;
        Debug.Log(hasKey);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        PlatformsToMove.Invoke();

    }

}
