using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using NUnit.Framework;

public class UITests : MonoBehaviour
{
    [SetUp]
    public void init()
    {
        SceneManager.LoadScene("Stage");
    }

    [UnityTest]
    public IEnumerator testClickLeaderBoardBtn()
    {
        var btnLeaderBoardGameObject = GameObject.Find("LeaderBoardButton");
        var btnLeaderBoard = btnLeaderBoardGameObject.GetComponent<Button>();
        btnLeaderBoard.onClick.Invoke();

        yield return new WaitForSeconds(3);

        var titleTodayTheme = GameObject.Find("Ttile");
        Assert.IsNotNull(titleTodayTheme, "Missing `Leader Board` title from `LeaderBoard` scene");
    }

        [UnityTest]
    public IEnumerator testClickBackBtn()
    {
        var btnLeaderBoardGameObject = GameObject.Find("LeaderBoardButton");
        var btnLeaderBoard = btnLeaderBoardGameObject.GetComponent<Button>();
        btnLeaderBoard.onClick.Invoke();

        yield return new WaitForSeconds(3);

        var titleTodayTheme = GameObject.Find("Ttile");
        Assert.IsNotNull(titleTodayTheme, "Missing `Leader Board` title from `LeaderBoard` scene");

        var btnBackGameObject = GameObject.Find("BackStage");
        var btnBack = btnBackGameObject.GetComponent<Button>();
        btnBack.onClick.Invoke();

        yield return new WaitForSeconds(3f);

        btnLeaderBoardGameObject = GameObject.Find("LeaderBoardButton");
        Assert.IsNotNull(btnLeaderBoardGameObject);
    }


    [UnityTest]
    public IEnumerator testSubmitGameScore()
    {
        // click start
        var btnStartGameObject = GameObject.Find("coverButton");
        var btnStart = btnStartGameObject.GetComponent<Button>();
        btnStart.onClick.Invoke();

        // Wait for game over
        yield return new WaitForSeconds(50);

        var txtNameGObj = GameObject.Find("name");
        var txtName = txtNameGObj.GetComponent<Text>();
        txtName.text = "testpayer";

        var btnSumitGameObject = GameObject.Find("Submit");
        var btnSumit = btnSumitGameObject.GetComponent<Button>();
        btnSumit.onClick.Invoke();

        yield return new WaitForSeconds(3);

        var tapToStartGameObject = GameObject.Find("ShootingGame Tap To Start");
        Assert.IsNotNull(tapToStartGameObject);
    }

    // [UnityTest]
    // public IEnumerator testMoveSpaceship()
    // {
    //     // click start
    //     var btnStartGameObject = GameObject.Find("coverButton");
    //     var btnStart = btnStartGameObject.GetComponent<Button>();
    //     btnStart.onClick.Invoke();

    //     // Wait a bit
    //     yield return new WaitForSeconds(.1f);

    //     var managerGameObj = GameObject.Find("Manager");
    //     var manager = managerGameObj.GetComponent<Manager>();
    //     Assert.IsNotNull(manager);

    //     GameObject playerGameObj = manager.player.gameObject;

    //     Assert.IsNotNull(playerGameObj);

    //     Player player = playerGameObj.GetComponent<Player>();
    //     Assert.IsNotNull(player);

	// 	Vector2 direction = new Vector2 (10, 5).normalized;
    //     Move(direction, player);

    //     yield return new WaitForSeconds(5);

    //     var btnSumitGameObject = GameObject.Find("Submit");
    //     var btnSumit = btnSumitGameObject.GetComponent<Button>();
    //     btnSumit.onClick.Invoke();

    //     yield return new WaitForSeconds(3);

    //     var tapToStartGameObject = GameObject.Find("ShootingGame Tap To Start");
    //     Assert.IsNotNull(tapToStartGameObject);
    // }

	// public void Move (Vector2 direction, Player player)
	// {
	// 	// 画面左下のワールド座標をビューポートから取得
	// 	Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
		
	// 	// 画面右上のワールド座標をビューポートから取得
	// 	Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
		
	// 	// プレイヤーの座標を取得
	// 	Vector2 pos = player.transform.position;
		
	// 	// 移動量を加える
	// 	pos += direction  * 5f * Time.deltaTime;
		
	// 	// プレイヤーの位置が画面内に収まるように制限をかける
	// 	pos.x = Mathf.Clamp (pos.x, min.x, max.x);
	// 	pos.y = Mathf.Clamp (pos.y, min.y, max.y);
		
	// 	// 制限をかけた値をプレイヤーの位置とする
	// 	player.transform.position = pos;

	// 	//---ゴーストをつくるため、ポジションをリスト化する-----
	// 	float[] postion = new float[2];
	// 	postion [0] = player.transform.position.x;
	// 	postion [1] = player.transform.position.y;
	// 	Player.posList.Add(postion);
	// 	//----------------------------------------------
	// }

    [TearDown]
    public void TearDown()
    {

    }
}
