using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private Rigidbody myBody;

    public void Move(float speed)
    {
        myBody.AddForce(transform.forward.normalized * speed);
        Invoke(nameof(DeactivateGameObject), 5f);
    }

    public void DeactivateGameObject()
    {
        gameObject.SetActive(false);
    }

    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == MyTags.OBSTACLE_TAG)
        {
            gameObject.SetActive(false);
        }
    }
}
