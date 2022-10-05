using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AlexzanderCowell


{
    public class SceneLoader : MonoBehaviour
    {
        public bool levelNext = false;

        private void Update(){
            if 
                (levelNext == true) {
                
                OnTriggerEnter2D();
            }
                
        }

        void OnTriggerEnter2D(Collider2D collision){
   
            if (collision.tag == "Player"){
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Debug.Log("You Win! now Next Level! :D ");            
            }



        }

    }

}
            
