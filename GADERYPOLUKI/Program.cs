//szyfr GA-DE-RY-PO-LU-KI
//podmieniamy literę na drugą z pary
//pozostałe litery przepisujemy jak leci
//kodując słowo GITARA -> AKTGYG

//funkcja kodująca przy użyciu switch/case
string switchGaderypoluki(string inputText)
{
    //zmienna na zakodowany tekst
    string output = String.Empty;
    //pętla znak po znaku
    foreach (char c in inputText)
    {
        //w każdym przebiegu pętli "c" będzie oznaczał aktualną literę w tekscie
        //instrukcja sterujaca switch
        switch (c)
        {
            //jeśli w tekscie źródłowym wystąpiła litera 'A'
            case 'A':
                //to do docelowego tekstu zapisujecie
                output += 'G';
                //na końcu każdego przypadku musi być break
                break;
            case 'G':
                output += 'A';
                break;
            //todo: uzupełnić o pozostałe pary


            //w każdym innym przypadku
            default:
                //przepisz znak
                output += c;
                break;
        }
    }
    return output;
}
string dictionaryGaderypoluki(string input)
{
    string output = string.Empty;
    Dictionary<char, char> dictionary = new Dictionary<char, char>()
    {
        {'A', 'G'}, {'G', 'A'},
        {'E', 'D'}, {'D', 'E'},
        {'R', 'Y'}, {'Y', 'R'},
        {'P', 'O'}, {'O', 'P'},
        {'L', 'U'}, {'U', 'L'},
        {'K', 'I'}, {'I', 'K'},
    };
    foreach (char c in input)
    {
        //jeżeli kluz występuje w słowniku to przepisz pasującą literę do nowego tekstu
        //i zapisz wynik działania (prawda/fałsz) do zmiennej found oraz znak do zmiennej temp

        //czy znalazł
        bool found = false;
        //pasujący znak - jeśli znalazł
        char temp = '\0';
        //szukaj, zapisz do found czy znalazłeś
        found = dictionary.TryGetValue(c, out temp);

        //!!!ważne - są dwie drogi od tego miejsca
        //1. found == true -> znak wystąpił w słowniku, w temp jest jego odpowiednik
        //2. found == false -> znak nie wystąpił w słowniku, temp jest pusty, przepisz c

        if(found)
            output += temp;
        else
            output += c;
        
    }
    //zwróć zaszyfrowany tekst
    return output;
}




//poproś użytkownika o tekst
Console.WriteLine("Podaj tekst do zaszyfrowania: ");
//przeczytaj go do zmiennej, jeśli zwróci null to zamiast tego zapisz do zmiennej pusty string
string input  = Console.ReadLine() ?? String.Empty;
//zamień wszystkie litery na wielkie
string pureText = input.ToUpper();




Console.WriteLine("Zakodowany tekst: ");
Console.WriteLine(switchGaderypoluki(pureText));
Console.WriteLine("Zakodowany tekst (słownik): ");
Console.WriteLine(dictionaryGaderypoluki(pureText));
