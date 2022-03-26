using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
    public GameObject BlackPistol;
    public AudioSource PistoSShot;
    public GameObject MuzzleFlash;

    public float ToTarget;

    public bool isFiring = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (isFiring == false)
            {
                StartCoroutine(Fire());
            }
        }
    }

    IEnumerator Fire()
    {
        isFiring = true;
        BlackPistol.GetComponent<Animator>().Play("Pistol");

        PistoSShot.Play();

        ToTarget = PlayerDistance.DistanceFromTarget;

        MuzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        MuzzleFlash.SetActive(false);

        yield return new WaitForSeconds(0.2f);
        BlackPistol.GetComponent<Animator>().Play("IdleState");
        isFiring = false;
    }
}
