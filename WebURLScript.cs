using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebURLScript : MonoBehaviour {

        public void btnOne()
    {
        Application.OpenURL("https://crawfordsautoservice.com/wp-content/uploads/2014/03/Crawfords_Auto_Repair_Guide.pdf");
    }

    public void btnTwo()
    {
        Application.OpenURL("http://booksite.elsevier.com/samplechapters/9780750675994/9780750675994.PDF");
    }

    public void btnThree()
    {
        Application.OpenURL("https://quizlet.com/123659597/basic-automotive-knowledge-flash-cards/");
    }
}
