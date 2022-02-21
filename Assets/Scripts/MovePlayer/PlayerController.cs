using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotationSpeed;
    private Touch _touch;
    private Vector3 touchDown;
    private Vector3 touchUp;
    private bool _dragStart;
    private bool _isMoving;
    private bool _touchedWall;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            
        
            _touch = Input.GetTouch(0);//ilk dokundu�umuz touch a e�itliyoruz.
            if (_touch.phase == TouchPhase.Began)
            {
                
                _dragStart = true;
                _isMoving = true;
                touchDown = _touch.position;
                touchUp = _touch.position;
            }
        }

        if (_dragStart )
        {
            if (_touch.phase == TouchPhase.Moved)
            {
                touchDown = _touch.position;
            }

            if (_touch.phase == TouchPhase.Ended)
            {
                
                touchDown = _touch.position;
                _isMoving = false;
                _dragStart = false;
            }
            gameObject.transform.rotation = Quaternion.RotateTowards(transform.rotation, CalculateRotation(), rotationSpeed * Time.deltaTime);
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
           
            //Burada asl�nda nesnemizin rotasyonu �nemlidir, parmak hareketimize g�re rotasyonu al�r ve s�rekli olarak
            //dokundu�umuz anda ileri do�ru gider.
        }

        Quaternion CalculateRotation()//rotasyon hesaplama fonksiyonumuz, hemen yukar�daki gidece�imiz rotasyon i�in kullan�yoruz.
        {
            Quaternion temp = Quaternion.LookRotation(CalculateDirection(), Vector3.up);
            return temp;
        }
        Vector3 CalculateDirection()
        {
            Vector3 temp = (touchDown - touchUp).normalized;
            temp.z = temp.y;
            temp.y = 0;
            return temp;
        }

    }
    private void OnTriggerEnter(Collider other)//Duvarlardan ge�isi karakterimizi Addforce ile de�ilde trasnform ile yapt���m�z i�in
        //bu �ekilde belirledi�imiz collider duvara girdi�inde h�z�n� d���rerek ge�ilmesi imkans�z duvarlar yapt�k.
        //karakterimiz rotasyonunu herhangi bir yere �evirdi�i an h�z�m�z tekrar artar.
    {
        if (other.gameObject.CompareTag("wall"))
        {
            movementSpeed = 0.1f;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            movementSpeed = 5;
        }
    }
 
}
