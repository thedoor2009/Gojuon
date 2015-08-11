using UnityEngine;
using System.Collections;

public class CharacterTest : MonoBehaviour {

	public static string[] Characters = new string[50];
	public static string[] Pronunciations = new string[50];

	private string m_character;
	private string m_pronunciation;

	private string m_displaycharacter;
	private string m_displaypronunciation;

	void Start () {

		Characters[0] = "あ";
		Characters[1] = "い";
		Characters[2] = "う";
		Characters[3] = "え";
		Characters[4] = "お";
		Characters[5] = "か";
		Characters[6] = "き";
		Characters[7] = "く";
		Characters[8] = "け";
		Characters[9] = "こ";

		Pronunciations[0] = "a";
		Pronunciations[1] = "i";
		Pronunciations[2] = "u";
		Pronunciations[3] = "e";
		Pronunciations[4] = "o";
		Pronunciations[5] = "ka";
		Pronunciations[6] = "ki";
		Pronunciations[7] = "ku";
		Pronunciations[8] = "ke";
		Pronunciations[9] = "ko";

		Characters[10] = "さ";
		Characters[11] = "し";
		Characters[12] = "す";
		Characters[13] = "せ";
		Characters[14] = "そ";
		Characters[15] = "た";
		Characters[16] = "ち";
		Characters[17] = "つ";
		Characters[18] = "て";
		Characters[19] = "と";

		Pronunciations[10] = "sa";
		Pronunciations[11] = "si";
		Pronunciations[12] = "su";
		Pronunciations[13] = "se";
		Pronunciations[14] = "so";
		Pronunciations[15] = "ta";
		Pronunciations[16] = "chi";
		Pronunciations[17] = "tsu";
		Pronunciations[18] = "te";
		Pronunciations[19] = "to";

		Characters[20] = "な";
		Characters[21] = "に";
		Characters[22] = "ぬ";
		Characters[23] = "ね";
		Characters[24] = "の";
		Characters[25] = "は";
		Characters[26] = "ひ";
		Characters[27] = "ふ";
		Characters[28] = "へ";
		Characters[29] = "ほ";

		Pronunciations[20] = "na";
		Pronunciations[21] = "ni";
		Pronunciations[22] = "nu";
		Pronunciations[23] = "ne";
		Pronunciations[24] = "no";
		Pronunciations[25] = "ha";
		Pronunciations[26] = "hi";
		Pronunciations[27] = "fu";
		Pronunciations[28] = "he";
		Pronunciations[29] = "ho";

		Characters[30] = "ま";
		Characters[31] = "み";
		Characters[32] = "む";
		Characters[33] = "め";
		Characters[34] = "も";
		Characters[35] = "や";
		Characters[36] = "い";
		Characters[37] = "ゆ";
		Characters[38] = "え";
		Characters[39] = "よ";

		Pronunciations[30] = "ma";
		Pronunciations[31] = "mi";
		Pronunciations[32] = "mu";
		Pronunciations[33] = "me";
		Pronunciations[34] = "mo";
		Pronunciations[35] = "ya";
		Pronunciations[36] = "i";
		Pronunciations[37] = "yu";
		Pronunciations[38] = "e";
		Pronunciations[39] = "yo";

		Characters[40] = "ら";
		Characters[41] = "り";
		Characters[42] = "る";
		Characters[43] = "れ";
		Characters[44] = "ろ";
		Characters[45] = "わ";
		Characters[46] = "い";
		Characters[47] = "う";
		Characters[48] = "え";
		Characters[49] = "を";

		Pronunciations[40] = "ra";
		Pronunciations[41] = "ri";
		Pronunciations[42] = "ru";
		Pronunciations[43] = "re";
		Pronunciations[44] = "ro";
		Pronunciations[45] = "wa";
		Pronunciations[46] = "i";
		Pronunciations[47] = "u";
		Pronunciations[48] = "e";
		Pronunciations[49] = "wo";

		int index = Random.Range(0,49);
		m_character = Characters[index];
		m_pronunciation = Pronunciations[index];

		m_displaycharacter = m_character;
		m_displaypronunciation = "";

	}

	void Update () {
	
	}

	void OnGUI(){

		GUI.Label(new Rect(Screen.width/2.0f, Screen.height - 450, 500, 500),"<color=green><size=50>" + m_displaycharacter + "</size></color>");

		GUI.Label(new Rect(Screen.width/2.0f, Screen.height - 350, 500, 500),"<color=green><size=50>" + m_displaypronunciation + "</size></color>");
	}

	public void NextCharacter(){
		int index = Random.Range(0,49);
		m_character = Characters[index];
		m_pronunciation = Pronunciations[index];

		m_displaycharacter = m_character;
		m_displaypronunciation = "";
	}

	public void ShowPronunciation(){
		m_displaypronunciation = m_pronunciation;
	}
}
