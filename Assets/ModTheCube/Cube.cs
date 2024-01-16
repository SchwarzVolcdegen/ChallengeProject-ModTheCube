using System.Collections;
using UnityEngine;

public class Cube : MonoBehaviour
{
  public MeshRenderer Renderer;
  
  void Start()
  {
      transform.position = new Vector3(3, 4, 1);
      transform.localScale = Vector3.one * 1.3f;
      
      // Start the color changing coroutine
      StartCoroutine(ChangeColorOverTime());
  }
  
  IEnumerator ChangeColorOverTime()
  {
      while (true)
      {
          // Generate a random color
          Color randomColor = Random.ColorHSV();
          
          // Change the material color
          Renderer.material.color = randomColor;
          
          // Wait for 1 second
          yield return new WaitForSeconds(0.5f);
      }
  }

  void Update()
  {
      transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
  }
}
