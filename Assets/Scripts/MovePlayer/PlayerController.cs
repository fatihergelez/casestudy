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
            
        
            _touch = Input.GetTouch(0);//ilk dokunduðumuz touch a eþitliyoruz.
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
           
            //Burada aslýnda nesnemizin rotasyonu önemlidir, parmak hareketimize göre rotasyonu alýr ve sürekli olarak
            //dokunduðumuz anda ileri doðru gider.
        }

        Quaternion CalculateRotation()//rotasyon hesaplama fonksiyonumuz, hemen yukarýdaki gideceðimiz rotasyon için kullanýyoruz.
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
    private void OnTriggerEnter(Collider other)//Duvarlardan geçisi karakterimizi Addforce ile deðilde trasnform ile yaptýðýmýz için
        //bu þekilde belirlediðimiz collider duvara girdiðinde hýzýný düþürerek geçilmesi imkansýz duvarlar yaptýk.
        //karakterimiz rotasyonunu herhangi bir yere çevirdiði an hýzýmýz tekrar artar.
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
