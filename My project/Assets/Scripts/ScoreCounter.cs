using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
	[SerializeField] private GameObject changeShapeScript;
	[SerializeField] private Text scoreCountText;
	private const string YOUDIED = "YOU DIED";
	private ChangeShape changeShape;


	private void Start()
	{
		changeShape = changeShapeScript.GetComponent<ChangeShape>();
	}

	private void Update()
	{
		scoreCountText.text = changeShape.score.ToString();

		if( FindObjectOfType<GameManager>().GameEnded == true )
		{
			scoreCountText.text = YOUDIED;
		}

	}
}
