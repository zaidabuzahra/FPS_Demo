using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoDisplay : MonoBehaviour
{
    public GameObject AmmoTextUI;

    public int BulletCount;
    // Update is called once per frame
    void Update()
    {
        AmmoTextUI.GetComponent<Text>().text = BulletCount.ToString();
    }
}