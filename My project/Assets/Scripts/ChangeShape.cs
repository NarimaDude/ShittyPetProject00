using UnityEngine.UI;
using UnityEngine;

public class ChangeShape : MonoBehaviour
{
	[SerializeField] private MeshFilter playerMesh;
    [SerializeField] private Mesh sphere, pyramid;
	public uint score = 0;
	private ObstacleType allowedObstacleType = ObstacleType.Pyramid;
    

    private void Update()
    {
		if( Input.GetKeyDown( KeyCode.Z ) )
		{
            playerMesh.mesh = pyramid;
			allowedObstacleType = ObstacleType.Pyramid;
		}

		if( Input.GetKeyDown( KeyCode.X ) )
		{
			playerMesh.mesh = sphere;
			allowedObstacleType = ObstacleType.Sphere;
		}
    }


	private void OnTriggerEnter( Collider other )
	{
		if( other.TryGetComponent( out Obstacle obstacle ) )
		{
			if( allowedObstacleType != obstacle.ObstacleType )
			{
				GetComponent<MovementScript>().enabled = false;
				FindObjectOfType<GameManager>().EndGame();
			}
			else
			{
				score++;
			}
		}
	}
}
