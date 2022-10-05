using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexzanderCowell
{


    public class LevellingSystem : MonoBehaviour
    {
        private int coins;
        public bool levelNext = false;

        private void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.tag == ("Player"))
            {

                coins = +1;
                Debug.Log(coins);
            }
        }

        private void Update()
        {
            if (coins == 3)
            {
                levelNext = true;
            }
        }


    }
}
