using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using System;
using Unity.VisualScripting;
using UnityEngine.UI;
using System.Threading;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D _rb2d;
    public float fuel = 100f;

    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;

    private Animator animator;

    void Awake()
    {
        _rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        RefillFuel();
    }

    private void RefillFuel()
    {
        if (fuel < 100f)
        {
            fuel += 0.1f;
        }
        else
        {
            fuel = 100f;
        }
    }

    public void Shoot()
    {
        if (fuel < 10)
            return;
        fuel -= FUELPERSHOOT;
        Vector2 velocity = Vector2.up * SPEED;
        _rb2d.AddForce(velocity, ForceMode2D.Impulse);
    }



    public void ToReStart()
    {
        animator.SetBool("IsBoom", true);
        Invoke("ReStartScene", 1f);
    }

    private void ReStartScene()
    {
        SceneManager.LoadScene("RocketLauncher");
    }


}
