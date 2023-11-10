using System;
using System.Collections.Generic;
using System.IO;
using DataStructures_Alorithms;

public class TextFileToStack
{

    public static void Main(string[] args)
    {
        //Instantiate Classes and execute their setup methods
        Array_Class a_Class = new Array_Class();
        a_Class.SetupArray();

        Dictionary_Class d_Class = new Dictionary_Class();
        d_Class.SetUpDictionary();

        Stack_Class s_Class = new Stack_Class();
        s_Class.SetupStack();

        Queue_Class q_Class = new Queue_Class();
        q_Class.SetupQueue();
    }
}