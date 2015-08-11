using UnityEngine;
using System.Collections;
using System.Reflection;

public enum ConjugationMode 
{
    Past,
    Negative,
    PastNegative
}

public enum WordType 
{
    StateOfBeing,
    VerbV1,
    VerbV5,
    VerbExSuru,
    VerbExKuru,
    AdjNa,
    AdjI,
    AdjExIi,

}


public class Conjugator : MonoBehaviour 
{
    void Start()
    {
        string oyogu = "泳ぐ";
        Debug.Log(oyogu);
        Debug.Log(oyogu.Length);

        Debug.Log(Conjugate(oyogu, ConjugationMode.Past, WordType.VerbV5));
    }

    public string Conjugate(string input, ConjugationMode mode, WordType destWordType)
    {
        MethodInfo mi = GetType().GetMethod("Conjugate_" + mode.ToString() + "_" + destWordType.ToString());
        if (mi != null)
        {
            if (mi.GetParameters().Length != 1 || mi.ReturnType != typeof(string))
            {
                Debug.LogError("Malformed Conjugation Handler: " + "Conjugate_" + mode.ToString() + "_" + destWordType.ToString());
                return "Error";
            }

            string result = mi.Invoke(this, new object[] {input} ) as string;
            return result;
        }
        else
        {
            Debug.LogError("No Conjugation Handler: " + "Conjugate_" + mode.ToString() + "_" + destWordType.ToString());
            Debug.LogWarning("The conjugation might not be defined for the given WordType. Better handling of these cases will come later");
            return "Error";
        }
    }

    #region Past V5
    public string Conjugate_Past_VerbV5(string input)
    {
        // handle 行く exception
        if (input == "行く")
        {
            return "行った";
        }

        int len = input.Length;
        char tail = input[len - 1];
        string first = input.Substring(0, len - 1);

        if (tail == 'う' || tail == 'つ' || tail == 'る')
        {
            return (first + "った");
        }
        else if (tail == 'く')
        {
            return (first + "いた");
        }
        else if (tail == 'ぐ')
        {
            return (first + "いだ");
        }
        else if (tail == 'す')
        {
            return (first + "した");
        }
        else if (tail == 'ぬ' || tail == 'ぶ' || tail == 'む')
        {
            return (first + "んだ");
        }

        return ("Could not conjugate " + input + " into past tense");
    }
    #endregion
}
