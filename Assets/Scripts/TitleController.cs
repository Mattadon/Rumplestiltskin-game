﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour {

	public string sceneToLoad;

	public void onClickPlay() {
		SceneManager.LoadScene(sceneToLoad);
	}
}
