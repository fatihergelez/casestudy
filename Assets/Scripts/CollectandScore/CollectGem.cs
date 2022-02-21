using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Collect
{
    //GemsPool dizisinden ObjectPool y�ntemiyle ram yorulmadan nesneler yok edildi ve tekrar aktif ediliyor.
    //Her nesne kapat�ld���nda GemsPool dizisinden random olarak 1 yeni nesne aktif ediliyor.
    //B�ylece ayn� anda sadece en fazla 5 nesne oyunda kal�yor.
    //Her collectable tag ile kar��la��ld���nda Score puan� +10 art�r�l�yor.
    public class CollectGem : MonoBehaviour
    {
        public GameObject[] GemsPool;
        public int Score;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("collectable"))
            {
                other.gameObject.SetActive(false);
                Score += 10;
                GemsPool[Random.Range(0, 10)].SetActive(true);
            }
        }
    }

}
