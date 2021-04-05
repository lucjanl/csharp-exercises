# Lekcja 1

## Metody i właściwości statyczne

C# należy do rodziny języków obiektowych. Ich wspólną cechą jest to, że takie języki operują na tzw. klasach. Upraszczając klasa może reprezentować pewien wycinek rzeczywistości. Także w języku nieprogramistycznym mówi się o pewnych klasach rzeczy albo wprowadza się klasyfikację. Np. taką klasyfikacją jest podział organizmów żywych na rośliny i zwierzęta. W tym sensie można mówić, że np. pies należy do klasy zwierząt, a rzodkiewka do klasy roślin. (Znowu upraszczając) cechą (tzw. **właściwością**) zwierząt jest to, że się poruszają, natomiast rośliny są nieruchome. Można więc to zapisać:

```
Zwierzę.PoruszaSię = tak;
Roślina.PoruszaSię = nie;
```

Mówiąc o zwierzęciu lub roślinie, mówimy o pewnym pojęciu abstrakcyjnym (czyli nie o konkretnej rzeczy materialnej). Natomiast możemy też mówić o konkretnych przedmiotach, np. o konkretnym psie: Fafiku. W świecie programistycznym mówi się wtedy o **instancji** klasy lub **obiekcie**. Taki obiekt może mieć pewne cechy (**właściwości**), które przynależą do tych konkretnych "egzemplarzy". W ten sposób nasz pies ma właściwość `Imię` o wartości `Fafik`.

W programowaniu klasa może mieć więc właściwości abstrakcyjne (czyli niezależne od konkretnych egzemplarzy), jak `PoruszaSię` - mówimy wtedy o właściwości **statycznej**. Właściwości mogą być też **niestatyczne** i wtedy będą odnosić się do konkretnego obiektu (instancji klasy, "egzemplarza"). Przykład: właściwość `Imię`, która dla jednego psa może mieć wartość `Fafik`, a dla innego `Reks`.

W C#, aby skorzystać z właściwości statycznej, używamy nazwy klasy + kropkę `.` + nazwę właściwości, np. `Pies.PoruszaSię`.

Natomiast aby skorzystać z właściwości niestetycznej, musimy mieć dostęp do obiektu tej klasy (np. możemy go stworzyć ze słówkiem `new` i zapisać do zmiennej), a potem - znowu używając kropki - wpisać nazwę właściwości. Czyli jeśli stworzymy obiekt psa przez `var pies = new Pies();` (zauważ, że tutaj przypisałem ten obiekt do zmiennej `pies`), to odniesienie do właściwości `Imię` będzie wyglądać tak: `pies.Imię`. Właściwość to tak jakby taka zmienna, tyle że na poziomie klasy i wyeksponowana przez klasę (o tym kiedy indziej). Upraszczając możemy jej użyć po to, by nadać psu imię:

```cs
pies.Imię = "Fafik";
```

lub po to, by je sprawdzić i - dajmy na to - wyświetlić na konsoli:

```cs
var imięPsa = pies.Imię;
Console.WriteLine(imięPsa);
```

> Zauważ, że kiedy chcemy zmienić wartość właściwości, znajduje się ona po lewej stronie znaku `=`, a kiedy chcemy pobrać wartość tej właściwości, znajduje się ona po prawej stronie znaku `=`. Dane więc "wędrują" od prawej do lewej. (Podobnie zapisuje się wartości zmiennych w matematyce, np. `x = 5, y = 10. Oblicz 4*x + 5*y.`).

> Możesz też zauważyć, że w tym drugim kawałku kodu `var imięPsa = pies.Imię` kierunek zapisu do zmiennej jest również od prawej do lewej.

> Analogia: na pytanie "Jak masz na imię?" łatwiej jest nam odpowiedzieć "Mam na imię Lucjan" niż "Lucjan mam na imię" - tak, jakbyśmy odpowiedzieli kodem `imię = "Lucjan"`.


## Typy proste

C# ma pewien zestwa typów prostych, do których należą między innymi `byte`, `int`, `long`, `float`, `string`, `DateTime`, `bool` i `char`. Każdy z tych typów (typ to szersze pojęcie niż klasa, ale o tym kiedy indziej) ma swoje metody i właściwości statyczne i niestatyczne.


```
git checkout unit2
```