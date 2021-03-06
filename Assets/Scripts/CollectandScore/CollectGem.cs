using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Collect
{
    //GemsPool dizisinden ObjectPool yöntemiyle ram yorulmadan nesneler yok edildi ve tekrar aktif ediliyor.
    //Her nesne kapatıldığında GemsPool dizisinden random olarak 1 yeni nesne aktif ediliyor.
    //Böylece aynı anda sadece en fazla 5 nesne oyunda kalıyor.
    //Her collectable tag ile karşılaşıldığında Score puanı +10 artırılıyor.
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
