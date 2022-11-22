Elev amanda = new( 1, "Amanda", "Gudmand", new DateOnly(1988, 2, 3)) ;

Elev alexander = new( 2, "Alexander", "Runge", new DateOnly(1999, 4, 2));

Elev ozan = new( 3, "Ozan", "Korkmaz", new DateOnly(1989, 7, 6));

Elev camilla = new( 4, "Camilla", "Kløjgaard", new DateOnly(2000, 6, 6));

Elev dennis = new( 5, "Dennis", "Paaske", new DateOnly(2010, 11, 12));


Lære niels = new("Lære", "Niels", "Olesen", new DateOnly(1974, 4, 12));

Fag grundlæggende = new("Grundelæggende Programmering", niels);
Fag studieteknik = new("Studieteknik", niels );
Fag oop = new("OOP", niels);

List<Tilmelding> Tilmeldinger = new()
{

new Tilmelding(amanda, oop),
new Tilmelding(amanda, grundlæggende),
new Tilmelding(amanda, studieteknik),


new Tilmelding(alexander, oop),
new Tilmelding(alexander, grundlæggende),
new Tilmelding(alexander, studieteknik),


new Tilmelding(ozan, oop),
new Tilmelding(ozan, grundlæggende),


new Tilmelding(camilla, oop),
new Tilmelding(camilla, grundlæggende),


new Tilmelding(dennis, oop),
new Tilmelding(dennis, grundlæggende),
new Tilmelding(dennis, studieteknik),
};


foreach (var item in Tilmeldinger)
{
    Console.WriteLine($"{item.ElevInfo.FirstName} {item.ElevInfo.LastName} Fag: {item.FagInfo.FagNavn} Lære: {item.FagInfo.LæreInfo.FirstName} {item.FagInfo.LæreInfo.LastName}");
}