using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public static class cargar 
{
  public static string siguientenivel;

  public static void NivelCargar(string nombre)
  {
    siguientenivel = nombre; 
    SceneManager.LoadScene("cargando");
  }
}
