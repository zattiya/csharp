//palindrom by Ziad Attiya. Written on June 28, 2023.

//detects palidrome. Displays the length of word. If "exit" is typed, program exits.
//Program ignored white space, and all punctuations. 



using System;
using System.Text;


(bool, int) IsPalindrome (string thestr){//returns bool for palindrome, and int for length
    string teststr; //to perform the palindrom test


    //converts string to upper. We are ignoring the case
    teststr= thestr.ToUpper();

    //strip of punctuations with StringBuilder
    var sb = new StringBuilder();
    foreach (char c in teststr){
        if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c)){
            sb.Append(c);
        }
    }
    //builder to a finished string
    thestr=sb.ToString();

    int i=0, j=teststr.Length-1; //Beginning and end indexes
    
    //when indexes are the same, the test is done 
    while (i<=j){
        if (teststr[i] != teststr[j]){return (false, 0);}//not palindrome}
        i++; j--; //move to next letter
    }
    //end of while loop

    //if non of the above happened, then it must be a palindrome.
    return (true, thestr.Length);
    
    }//end of function

string inputstr="";
(bool b, int l) result;
Console.WriteLine("Lets begin!: ");
while (inputstr!="exit"){
    inputstr=Console.ReadLine();
    if (inputstr!="exit"){
        result=IsPalindrome(inputstr);
        Console.WriteLine($"Palindrome: {result.b}, Length: {result.l}");
    }
}

    