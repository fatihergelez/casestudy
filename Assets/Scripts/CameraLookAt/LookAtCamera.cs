using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{   //public olarak belirlediğimiz hedef değişkenimiz(player) LookAt komutu sayesinde kameramız karakterimizi takip ediyor.
    public Transform target;

    private void LateUpdate()
    {
        transform.LookAt(target);
    }
}
