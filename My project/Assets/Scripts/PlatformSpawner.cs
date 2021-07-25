using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
	private const float MAXPLATFORMS = 20f;
	[SerializeField] private PlatformTile platformTile;
	public Vector3 nextSpawnPoint;
	private List<PlatformTile> spawnedPlatforms = new List<PlatformTile>();


	private void Start()
	{
		// Spawning some platforms at start
		for( int i = 0; i < MAXPLATFORMS; i++ )
		{
			SpawnPlatform();
		}
	}


	public void SpawnPlatform()
	{
		PlatformTile tile = Instantiate<PlatformTile>( platformTile, nextSpawnPoint, Quaternion.identity );  // Creating new platforms

		if( spawnedPlatforms.Count == MAXPLATFORMS )
		{
			Destroy( spawnedPlatforms[ 0 ].gameObject );
			spawnedPlatforms.RemoveAt( 0 );
		}

		spawnedPlatforms.Add( tile );
		nextSpawnPoint += new Vector3( 0, 0, 20 );


		tile.Init( this );
	}
}