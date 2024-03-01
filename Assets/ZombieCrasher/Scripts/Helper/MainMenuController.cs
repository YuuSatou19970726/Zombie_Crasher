using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    [SerializeField]
    private Animator cameraAnim;

    public void PlayGame() {
        cameraAnim.Play ("Slide");
    }
}
