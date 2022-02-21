using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{   //public olarak belirlediðimiz hedef deðiþkenimiz(player) LookAt komutu sayesinde kameramýz karakterimizi takip ediyor.
    public Transform target;

    private void LateUpdate()
    {
        transform.LookAt(target);
    }
}
