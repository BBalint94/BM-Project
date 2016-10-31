# Rendszerterv:

### A rendszer célja:
  A felhasználó szórakoztatása egy WPF-es alkalmazás által, ami egy egyszemélyes körökre osztott RPG alapú játék. A felhasználó egy karaktert hoz létre, amelynek választhat egy profilképet, megadhatja a nevét, választhat három kaszt közül egyet (harcos, mágus, íjász), illetve választhat egy fegyvert a kasztjához tartozó fegyverek közül. Ezután elkezdődik a játék, baloldalt megjelennek a karakterünk adatai (karakterünk neve, profilkép, életerősáv, kasztunk neve, karakter fegyvere), középen a különböző interakciók gombjai, jobboldalt az ellenségünk adatai (az alkalmazás választja ki véletlenszerűen az ellenséget), alul pedig az események olvashatóak. Az események az interakció gombok használatával történnek (támadás...stb.). A játékos akkor győz, ha az ellenfélnek 0-ra csökkenti az életerejét úgy, hogy a saját életereje nagyobb mint 0. Ha mindkét fél életereje 0-ra csökken, akkor az eredmény döntetlen, ha pedig csak a mi életerőnk lesz 0, akkor vesztettünk. Ha győzünk a játék megjutalmaz minket játékbeli pénz formájában. Kilépés esetén az alkalmazás elmenti a karakterünk állapotát, így később folytathatjuk a játékot onnan ahol abbahagytuk.

### Project terv:
 * Erőforrások:
    1. emberi: az alkalmazás elkészítésén 2 fő dolgozik
    2. szükséges hardverek:
      - legalább 1.6 GHz-es processzor
      - 1.5 Gb RAM
      - több mint 4 Gb tárhely a merevlemezen a Visual Studio számára
      - DirectX 9 -et támogató videókártya (1024 x 768 vagy ettől nagyobb felbontás)
    3. szükséges szoftverek:
      - Windows 7-es vagy attól újabb operációs rendszer
      - Visual Studio Community 2015
      - Microsoft Office 2007 vagy attól újabb verziójú szoftver

* Időszükségleti terv:
>  Az alkalmazás létrehozásához 3 hónap áll rendelkezésre.
>    1. Követelmény specifikáció (határidő: 2016. október 2.)
>    2. Rendszerterv (határidő: 2016. október 31.)
>    3. Prototípus (határidő: 2016. október 31.)
>    4. Tesztelési terv (2016 november vége)
>    5. Kész alkalmazás (2016 november vége)
>    6. Bemutató a kész alkalmazáshoz (2016. december 12.)

* Felelősségi körök, feladatok:
  * Ábel Márk:
    - alkalmazás vizuális megjelenésének elkészítése
    - játékos karakter osztályának és interface-ének megírása
    - kasztok osztályának és interface-einek megírása
    - fegyvertípusok típusonkénti kidolgozása
    - ellenség osztály megírása
    - felhasználói felület kialakítása
  * Bogáti Bálint:
    - felhasználói felület kialakítása
    - konténer osztály megírása a karakterek számára
    - konténer osztály a fegyvereknek
    - az adatok tárolásának megoldása (fájlból beolvasás, fájlba írás)
    - a felhasználói felületen található elemek (pl. gombok, beviteli mezők) funkcióinak megírása
  * Eddig még ki nem osztott feladatok:
    * prototípus továbbfejlesztése:
        - az interakciók gombjainak kibővítése (pl. védekezés, élet visszatöltés)
        - játékbeli pénzrendszer bevezetése
        - boltrendszer kialakítása
        - korábbi játékállás folytatása (betöltés)
        - életerősáv a szöveges változat helyett
        - tárgyak listájának kibővítése
        - animáció készítése, ami az interakciók hatására lejátszódik
### Fejlesztés során használt szoftverkomponensek:
  * Visual Studio Community 2015: ingyenesen letölthető tanuló verzió
  * Microsoft Office: ingyenes tanulói verzió
  * GitHub
  * Windows operációs rendszer: iskolai ingyenes verzió
