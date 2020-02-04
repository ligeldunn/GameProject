using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static SoundManager instance;

    [SerializeField]
    private AudioSource Collison_FX, Move_FX;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    public void Collision_Player()
    {
        Collison_FX.Play();
    }
    public void Move_Player()
    {
        Move_FX.Play();
    }

}
