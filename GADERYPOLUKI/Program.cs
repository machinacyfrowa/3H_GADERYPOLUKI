//szyfr GA-DE-RY-PO-LU-KI
//podmieniamy literę na drugą z pary
//pozostałe litery przepisujemy jak leci
//kodując słowo GITARA -> AKTGYG

//poproś użytkownika o tekst
Console.WriteLine("Podaj tekst do zaszyfrowania: ");
//przeczytaj go do zmiennej, jeśli zwróci null to zamiast tego zapisz do zmiennej pusty string
string input  = Console.ReadLine() ?? String.Empty;
//zamień wszystkie litery na wielkie
string pureText = input.ToUpper();
//przygotuj zmienną na zakodowany tekst
string encodedText = String.Empty;

foreach (char c in pureText)
{
    //w każdym przebiegu pętli "c" będzie oznaczał aktualną literę w tekscie
    //instrukcja sterujaca switch
    switch(c)
    {
        //jeśli w tekscie źródłowym wystąpiła litera 'A'
        case 'A':
            //to do docelowego tekstu zapisujecie
            encodedText += 'G';
            //na końcu każdego przypadku musi być break
            break;
        case 'G':
            encodedText += 'A';
            break;
        //w każdym innym przypadku
        default: 
            //przepisz znak
            encodedText += c; 
            break;
    }
}

Console.WriteLine("Zakodowany tekst: ");
Console.WriteLine(encodedText);
