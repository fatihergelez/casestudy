using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour
{   //public olarak belirledi�imiz hedef de�i�kenimiz(player) LookAt komutu sayesinde kameram�z karakterimizi takip ediyor.
    public Transform target;

    private void LateUpdate()
    {
        transform.LookAt(target);
    }
}
