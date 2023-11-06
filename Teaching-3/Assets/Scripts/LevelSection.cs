using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSection : MonoBehaviour
{
	public DifficultyState difficulty;
	public enum DifficultyState
	{
		easy,
		normal,
		hard,
	}

	public void Easy()
	{
		difficulty = DifficultyState.easy;
		Debug.Log("difficulty: " + difficulty);
		SceneManager.LoadScene("Test");
	}

	public void Normal()
	{
		difficulty = DifficultyState.normal;
		Debug.Log("difficulty: " + difficulty);
		SceneManager.LoadScene("SampleScene");
	}

	public void Hard()
	{
		difficulty = DifficultyState.hard;
		Debug.Log("difficulty: " + difficulty);
		// SceneManager.LoadScene();
	}
}
