using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AlexzanderCowell
{
    
  
    public class LevellingSystem : MonoBehaviour
    {
        private int coins;
        public bool levelNext;

        private void Update(){
            
        }



        private void OnTriggerEnter2D(Collider2D other){

            if (other.gameObject.CompareTag("Coins")){

                levelNext = true;

                


            }
        }    
    }
}
