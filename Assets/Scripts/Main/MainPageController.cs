﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainPageController : MonoBehaviour {

	public Image BookPicture;

	private MainPage_UIManager UIManager;
	private float timeToCloseApp = 0;

	private void Start() {
		UIManager = GameObject.Find("MainPage_UIManager").GetComponent<MainPage_UIManager>();
	}

	private void Update() {

		if (timeToCloseApp > (Time.time - 1.2f)) {
			if (Input.GetKeyDown(KeyCode.Escape)) {
				Application.Quit();
			}
		} else {
			if (Input.GetKeyDown(KeyCode.Escape)) {
				timeToCloseApp = Time.time;
			}
		}
	}

	public void OnClick_NotificationItem(int i) {
		AndroidNativeFunctions.ShowAlert("Notification Touched",
					"",
					"Got it", "", "",
					(action) => {
						print("Hello adb !");
					}
		);
	}

	public void OnClick_BookItem(int bookId) {
		//BookPicture.sprite = new Sprite();
		UIManager.ShowBookDetail();
	}

	public void OnClick_Account(int bookId) {
		AndroidNativeFunctions.ShowAlert("Touched",
					"",
					"Got it", "", "",
					(action) => {
						print("Hello adb !");
					}
		);
	}

	public void OnClick_ChangePassword(int bookId) {
		AndroidNativeFunctions.ShowAlert("Touched",
					"",
					"Got it", "", "",
					(action) => {
						print("Hello adb !");
					}
		);
	}

	public void OnClick_TremServices(int bookId) {
		AndroidNativeFunctions.ShowAlert("Touched",
					"",
					"Got it", "", "",
					(action) => {
						print("Hello adb !");
					}
		);
	}

	public void OnClick_Logout(int bookId) {
		AndroidNativeFunctions.ShowAlert("Logout",
					"",
					"Got it", "", "",
					(action) => {
						print("Hello adb !");
					}
		);

		PlayerPrefs.DeleteAll();
		SceneManager.LoadScene("Initialization");
	}

}
