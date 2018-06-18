using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Match3Core;

public class ClearComponent : Clearable {

	public AnimationClip clipClear;

	private void Awake()
	{
		SetAnimationOnClear (clipClear);
	}
}
