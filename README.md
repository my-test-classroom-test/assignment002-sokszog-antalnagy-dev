# assignment-002-sokszog

### Feladat 1: Absztrakt osztály létrehozása (10 pont)
- Készítsen egy `Sokszög` nevű absztrakt osztályt.
- Az osztály tartalmazzon egy `double` típusú `oldalak` nevű tömböt, amely az oldalak hosszát tárolja.

### Feladat 2: Konstruktor implementálása (10 pont)
- Implementáljon egy egyparaméteres konstruktort a `Sokszög` osztályban.
- A konstruktor kapja meg kívülről, hogy hány oldala lesz a sokszögnek, és hozzon létre egy ennyi elemű tömböt.

### Feladat 3: Virtuális kerületszámító metódus létrehozása (10 pont)
- Készítsen egy `kerület` nevű virtuális metódust a `Sokszög` osztályban.
- A metódus számolja össze az oldalak hosszát, és adja vissza ezt az összeget.

### Feladat 4: Absztrakt területszámító metódus létrehozása (10 pont)
- Hozzon létre egy absztrakt `terület` nevű metódust a `Sokszög` osztályban.
- A metódusnak nem kell implementáció, csak a származtatott osztályokban valósítják meg.

### Feladat 5: Háromszög osztály létrehozása (10 pont)
- Származtasson egy `Háromszög` nevű osztályt a `Sokszög` osztályból.
- Implementáljon egy konstruktort, amely ellenőrzött módon bekéri a háromszög oldalait.
- Vizsgálja meg a háromszög egyenlőtlenség teljesülését.

### Feladat 6: Téglalap osztály létrehozása (10 pont)
- Származtasson egy `Téglalap` nevű osztályt a `Sokszög` osztályból.
- Implementáljon egy konstruktort, amely ellenőrzött módon bekéri a téglalap oldalait.
- Ellenőrizze, hogy az oldalhosszak ne lehessenek negatívak vagy nullák.

### Feladat 7: Konstruktornál a base kulcsszó használata (10 pont)
- A `Háromszög` és a `Téglalap` osztály konstruktorában használja a `base` kulcsszót az ősosztály konstruktorának meghívásához.

### Feladat 8: Háromszög területszámító metódus implementálása (10 pont)
- Valósítsa meg a `terület` metódust a `Háromszög` osztályban.
- Használja a Héron-képletet a terület kiszámításához.

### Feladat 9: Téglalap területszámító metódus implementálása (10 pont)
- Valósítsa meg a `terület` metódust a `Téglalap` osztályban.
- Számolja ki a téglalap területét a hosszabb és rövidebb oldalak szorzatával.