using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
	[SerializeField] private ObstacleType obstacleType;
	public ObstacleType ObstacleType => obstacleType;
}


public enum ObstacleType
{
	Sphere,
	Pyramid,
}
