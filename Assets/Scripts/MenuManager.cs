using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    //Funcion para cargar el primer nivel
   public void LoadLevel1()
   {
       SceneManager.LoadScene("Nivel 1");
   }

   public void LoadMenuPrincipal()
   {
       SceneManager.LoadScene("Menu principal");
   }

   public void LoadPantalladeVictoria()
   {
       SceneManager.LoadScene("Pantalla de victoria");
   }

   public void LoadPantallaFinal()
   {
       SceneManager.LoadScene("Pantalla final");
   }

}
