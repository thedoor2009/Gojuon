using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CharacterTest : MonoBehaviour {

	public static string[] Characters = new string[75];
	public static string[] Pronunciations = new string[75];

    [SerializeField]
    private InputField m_inputField;

	private string m_character;
	private string m_pronunciation;

	private string m_displaycharacter;
	private string m_displaypronunciation;
    private string m_feedback;

    private string m_currentlyEnteredText;

	void Start () {
        if (m_inputField != null)
        { 
            m_inputField.Select();
            m_inputField.ActivateInputField();
        }

        m_feedback = "<color=blue><size=30>頑張って！</size></color>";

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
		Pronunciations[11] = "shi";
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

        Characters[50] = "が";
        Characters[51] = "ぎ";
        Characters[52] = "ぐ";
        Characters[53] = "げ";
        Characters[54] = "ご";
        Characters[55] = "だ";
        Characters[56] = "ぢ";
        Characters[57] = "づ";
        Characters[58] = "で";
        Characters[59] = "ど";

        Pronunciations[50] = "ga";
        Pronunciations[51] = "gi";
        Pronunciations[52] = "gu";
        Pronunciations[53] = "ge";
        Pronunciations[54] = "go";
        Pronunciations[55] = "da";
        Pronunciations[56] = "ji";
        Pronunciations[57] = "dzu";
        Pronunciations[58] = "de";
        Pronunciations[59] = "do";

        Characters[60] = "ざ";
        Characters[61] = "じ";
        Characters[62] = "ず";
        Characters[63] = "ぜ";
        Characters[64] = "ぞ";
        Characters[65] = "ば";
        Characters[66] = "び";
        Characters[67] = "ぶ";
        Characters[68] = "べ";
        Characters[69] = "ぼ";

        Pronunciations[60] = "za";
        Pronunciations[61] = "ji";
        Pronunciations[62] = "zu";
        Pronunciations[63] = "ze";
        Pronunciations[64] = "zo";
        Pronunciations[65] = "ba";
        Pronunciations[66] = "bi";
        Pronunciations[67] = "bu";
        Pronunciations[68] = "be";
        Pronunciations[69] = "bo";

        Characters[70] = "ぱ";
        Characters[71] = "ぴ";
        Characters[72] = "ぷ";
        Characters[73] = "ぺ";
        Characters[74] = "ぽ";

        Pronunciations[70] = "pa";
        Pronunciations[71] = "pi";
        Pronunciations[72] = "pu";
        Pronunciations[73] = "pe";
        Pronunciations[74] = "po";

		int index = Random.Range(0,Pronunciations.Length);
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

        GUI.Label(new Rect(Screen.width / 2.0f, Screen.height - 200, 500, 500), m_feedback);
    }

    public void CheckAnswer()
    {
        if (m_inputField != null)
        {
            string input = m_inputField.text;

            if (input != m_pronunciation)
            {
                m_feedback = "<color=red><size=30>もう一度！</size></color>";
                m_inputField.text = "";

                m_inputField.Select();
                m_inputField.ActivateInputField();
            }
            else
            {
                if (Random.Range(0, 100) < 50)
                {
                    m_feedback = "<color=green><size=30>完璧！</size></color>";
                }
                else
                {
                    m_feedback = "<color=green><size=30>最高！</size></color>";
                }

                NextCharacter();
            }
        }
    }

	private void NextCharacter(){
		int index = Random.Range(0,Pronunciations.Length);
        m_inputField.text = "";
		m_character = Characters[index];
		m_pronunciation = Pronunciations[index];

		m_displaycharacter = m_character;
		m_displaypronunciation = "";
        m_inputField.Select();
        m_inputField.ActivateInputField();
	}

	public void ShowPronunciation(){
		m_displaypronunciation = m_pronunciation;
	}
}
