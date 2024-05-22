using UnityEngine;
using UnityEngine.UI;
public class control : MonoBehaviour {
       	
    int y1 = 0, y2 = 0, y3 = 0, y4 = 0, y5 = 0, y6 = 0;
    int eseq1 = 0, eseq2 = 0, eseq3 = 0, eseq4 = 0, eseq5 = 0, eseq6 = 0;
    int cseq1 = 0, cseq2 = 0, cseq3 = 0, cseq4 = 0, cseq5 = 0, cseq6 = 0;

    string btnname;
    public void resetval()
    {
        eseq1 = 0; eseq2 = 0; eseq3 = 0; eseq4 = 0; eseq5 = 0; eseq6 = 0;
        cseq1 = 0; cseq2 = 0; cseq3 = 0; cseq4 = 0; cseq5 = 0; cseq6 = 0;
        y1 = 0; y2 = 0; y3 = 0; y4 = 0; y5 = 0; y6 = 0;
    }
    public void next()
    {
        switch (btnname)
        {
            case "func1": func1(); break;
            case "func2": func2(); break;
            case "func3": func3(); break;
            case "func4": func4(); break;
            case "func5": func5(); break;
            case "func6": func6(); break;
            case "func7": func7(); break;
            case "func8": func8(); break;
            case "func9": func9(); break;
            case "func10": func10(); break;
            case "func11": func11(); break;
            case "func12": func12(); break;
        }

    }
    public void func1()
    {
        btnname = "func1";
        y1++;
        if (y1 % 2 == 1)
        {
            eseq1++;
            FindObjectOfType<sc>().na_employee(eseq1,cseq1);
        }
        else
        {
            cseq1++;
            FindObjectOfType<sc>().na_employee(eseq1, cseq1);
        }
        //Debug.Log("Aya");
    }
    public void func2()
    {
        btnname = "func2";
        y2++;
        if (y2 % 2 == 1)
        {
            eseq2++;
            FindObjectOfType<sc>().de_employee(eseq2, cseq2);
        }
        else
        {
            cseq2++;
            FindObjectOfType<sc>().de_employee(eseq2, cseq2);
        }
        //Debug.Log("Aya");
    }
    public void func3()
    {
        btnname = "func3";
        y3++;
        if (y3 % 2 == 1)
        {
            eseq3++;
            FindObjectOfType<sc>().wi_employee(eseq3, cseq3);
        }
        else
        {
            cseq3++;
            FindObjectOfType<sc>().wi_employee(eseq3, cseq3);
        }
        //Debug.Log("Aya");
    }
    public void func4()
    {
        btnname = "func4";
        y4++;
        if (y4 % 2 == 1)
        {
            eseq4++;
            FindObjectOfType<sc>().ch_employee(eseq4, cseq4);
        }
        else
        {
            cseq4++;
            FindObjectOfType<sc>().ch_employee(eseq4, cseq4);
        }
        //Debug.Log("Aya");
    }
    public void func5()
    {
        btnname = "func5";
        y5++;
        if (y5 % 2 == 1)
        {
            eseq5++;
            FindObjectOfType<sc>().pu_employee(eseq5, cseq5);
        }
        else
        {
            cseq5++;
            FindObjectOfType<sc>().pu_employee(eseq5, cseq5);
        }
        //Debug.Log("Aya");
    }
    public void func6()
    {
        btnname = "func6";
        y6++;
        if (y6 % 2 == 1)
        {
            eseq6++;
            FindObjectOfType<sc>().bm_employee(eseq6, cseq6);
        }
        else
        {
            cseq6++;
            FindObjectOfType<sc>().bm_employee(eseq6, cseq6);
        }
        //Debug.Log("Aya");
    }
    public void func7()
    {
        btnname = "func7";
        y1++;
        if (y1 % 2 == 1)
        {
            eseq1++;
            FindObjectOfType<sc2>().Loan_Eq(eseq1, cseq1);
        }
        else
        {
            cseq1++;
            FindObjectOfType<sc2>().Loan_Eq(eseq1, cseq1);
        }
    }
    public void func8()
    {
        btnname = "func8";
        y2++;
        if (y2 % 2 == 1)
        {
            eseq2++;
            FindObjectOfType<sc2>().Loan_Home(eseq2, cseq2);
        }
        else
        {
            cseq2++;
            FindObjectOfType<sc2>().Loan_Home(eseq2, cseq2);
        }
    }
    public void func9()
    {
        btnname = "func9";
        y3++;
        if (y3 % 2 == 1)
        {
            eseq3++;
            FindObjectOfType<sc2>().Loan_Per(eseq3, cseq3);
        }
        else
        {
            cseq3++;
            FindObjectOfType<sc2>().Loan_Per(eseq3, cseq3);
        }
    }
    public void func10()
    {
        btnname = "func10";
        y4++;
        if (y4 % 2 == 1)
        {
            eseq4++;
            FindObjectOfType<sc2>().Loan_Car(eseq4, cseq4);
        }
        else
        {
            cseq4++;
            FindObjectOfType<sc2>().Loan_Car(eseq4, cseq4);
        }
    }
    public void func11()
    {
        btnname = "func11";
        y5++;
        if (y5 % 2 == 1)
        {
            eseq5++;
            FindObjectOfType<sc2>().Loan_Edu(eseq5, cseq5);
        }
        else
        {
            cseq5++;
            FindObjectOfType<sc2>().Loan_Edu(eseq5, cseq5);
        }
    }
    public void func12()
    {
        btnname = "func12";
        y6++;
        if (y6 % 2 == 1)
        {
            eseq6++;
            FindObjectOfType<sc2>().Loan_Boss(eseq6, cseq6);
        }
        else
        {
            cseq6++;
            FindObjectOfType<sc2>().Loan_Boss(eseq6, cseq6);
        }
    }
    

}
