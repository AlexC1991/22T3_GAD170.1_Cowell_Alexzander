using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AlexzanderCowell


{
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] private LevellingSystem levellingSystem;
        

        private void Update(){
            if 
                (levellingSystem.levelNext == true){

                  
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
            
