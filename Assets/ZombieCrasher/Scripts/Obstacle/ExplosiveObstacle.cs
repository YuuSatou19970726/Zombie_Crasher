using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveObstacle : MonoBehaviour
{
    [SerializeField]
    private GameObject explosionPrefab;
    [SerializeField]
    private int damage = 20;

    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == MyTags.PLAYER_TAG) {
            Instantiate (explosionPrefab, transform.position, Quaternion.identity);
            // DEAL DAMAGE
            target.gameObject.GetComponent<PlayerHealth> ().ApplyDamge(damage);
            
            gameObject.SetActive (false);
        }

        if (target.gameObject.tag == MyTags.BULLET_TAG) {
            Instantiate (explosionPrefab, transform.position, Quaternion.identity);
            gameObject.SetActive (false);
        }
    }
}
