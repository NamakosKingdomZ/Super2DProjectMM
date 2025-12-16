

using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
	public string Fin;

	private void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Entró algo al trigger: " + other.name);

		if (other.CompareTag("Player"))
		{
			Debug.Log("Es el jugador, cambiando escena");
			SceneManager.LoadScene(Fin);
		}
	}
}
