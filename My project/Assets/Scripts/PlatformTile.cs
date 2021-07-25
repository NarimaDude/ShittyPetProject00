using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTile : MonoBehaviour
{
	[SerializeField] GameObject circleHoleWall, pyramidHoleWall;
	[SerializeField] private Transform spawnPoint;
	private PlatformSpawner platformSpawner;


	public void Init( PlatformSpawner spawner )
	{
		platformSpawner = spawner;
		SpawnObstacle();
	}


	private void OnTriggerExit( Collider other )
	{
		// Spawn a new platform and destroy an old one
		platformSpawner.SpawnPlatform();
	}


	private void SpawnObstacle()
	{
		int obstacleIndex = Random.Range( 1, 3 );

		switch( obstacleIndex )
		{
			case 1:
				Instantiate( circleHoleWall, spawnPoint.position, Quaternion.identity, transform );
				break;
			case 2:
				Instantiate( pyramidHoleWall, spawnPoint.position, Quaternion.identity, transform );
				break;
		}
	}
}
