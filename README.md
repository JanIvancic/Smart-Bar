# Inicijalne upute za prijavu projekta iz Razvoja programskih proizvoda

# Aplikacija za vođenje inventara i izdaju računa ugostiteljskih objekata

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Mladen Kajić | mkajic20@student.foi.hr | 0016147999 | mkajic20
Luka Galjer | lgaljer20@student.foi.hr | 0016148489 | lgaljer20
Jan Ivančić | jivancic20@student.foi.hr | 0016150494 | jivancic20

## Opis domene
Ugostiteljski objekti, osim što izdaju račune gostima, zaprimaju robu na skladište i vode inventar vlastitog skladišta prema kojem izdaju narudžbenice za narudžbu nove robe. Softversko rješenje će omogućiti vođenje inventara i izdaju računa gostima.

## Specifikacija projekta

Aplikacija će imati dvije vrste korisnika sa različitim ovlastima. Imati će odvojenu bazu podataka na serveru kojoj će samo ovlašteni korisnici moći pristupiti. Funkcionalnosti, njihovi opisi te članovi odgovorni za njihovu implementaciju su navedeni u tablici ispod.

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Login | Za pristup aplikaciji, korisnik se treba prijaviti u sustav korištenjem multi-factor autentifkacije. | Mladen Kajić
F02 | Upravljanje računima | Aplikacija će korisniku omogućiti prikaz računa, storniranje računa i ispis računa. | Mladen Kajić
F03 | Izdavanje računa | Omogućuje kreiranje računa i izdavanje računa u pdf obliku. | Mladen Kajić
F04 | Upravljanje inventarom | Aplikacija će korisniku omogućiti dodavanje novih proizvoda, te ažuriranje i brisanje postojećih. Također će omogućiti definiranje minimalne i optimalne količine proizvoda. | Jan Ivančić
F05 | Upravljanje narudžbenicama | Aplikacija će korisniku omogućiti ručno kreiranje narudžbenica za nabavu novih proizvoda, upravljanje postojećim narudžbenicama te izdavanje narudžbenica u pdf obliku. | Jan Ivančić
F06 | Automatsko generiranje narudžbenice | Aplikacija će korisniku omogućiti automatsko kreiranje narudžbenica za nabavu proizvoda čija je količina na skladištu ispod minimalne, te slanje narudžbenice na mail dobavljača. | Jan Ivančić
F07 | Kreiranje primke | Aplikacija će omogućiti ručno kreiranje primke ili automatsko kreiranje na temelju postojeće narudžbenice. | Luka Galjer
F08 | Izrada inventurnog zapisnika | Aplikacija će omogućiti provedbu inventure skladišta gdje će se kreirati inventurni zapisnik. | Luka Galjer
F09 | Grafički prikaz stanja inventara | Aplikacija će omogućiti grafički prikaz stanja inventara uporabom grafova. | Luka Galjer


## Tehnologije i oprema

Za rad i manipulaciju baze podataka ćemo koristiti Microsoft SQL Server te SQL Server Management Studio. Za verzioniranje projekta koristiti ćemo Git i GitHub. Za implementaciju same aplikacije koristiti ćemo MS Visual Studio, .NET Framework, WinForms te C# programski jezik. Za pisanje dokumentacije projekta koristiti ćemo GitHub Wiki. Za izradu dijagrama služiti ćemo se alatom Visual Paradigm. Za pomoć u izradi projekta koristiti ćemo se dostupnim materijalima sa kolegija Razvoj Programskih Proizvoda te službenom C# dokumentacijom.
