﻿using UnityEngine;

using System.Collections;

namespace SupplyDrop.Utils
{
	public class Spin : MonoBehaviour
	{
		public float speed = 20;

		void Update()
		{
			if (Time.deltaTime == 0f)
			{
				return;
			}
			transform.Rotate(Vector3.up, speed * Time.deltaTime);
		}
	}
}