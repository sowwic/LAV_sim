﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    public AudioSource explosionSourse;
    void Start()
    {
        explosionSourse.Play();
    }

}
