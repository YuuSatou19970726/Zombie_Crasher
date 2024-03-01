using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [SerializeField]
    private float timer = 3f;

    void Start()
    {
        Invoke(nameof(DeactivateGameObject), timer);
    }

    void DeactivateGameObject() {
        gameObject.SetActive (false);
    }
}
