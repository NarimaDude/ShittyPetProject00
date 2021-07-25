using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private bool gameEnded = false;

	public bool GameEnded
	{
		get
		{
			return gameEnded;
		}
		private set
		{
			gameEnded = value;
		}
	}


	public void EndGame()
	{
		if( gameEnded == false )
		{
			gameEnded = true;
			Invoke("RestartGame", 2.0f);
		}
	}


	private void RestartGame()
	{
		SceneManager.LoadScene( SceneManager.GetActiveScene().name );
	}
}
