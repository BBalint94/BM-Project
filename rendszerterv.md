# Rendszerterv:

### A rendszer célja:
  A felhasználó szórakoztatása, ismereteinek kibővítése egy WPF-es alkalmazás által, ami egy egyszemélyes körökre osztott RPG alapú játék. A felhasználó egy karaktert hoz létre, amelynek választhat egy profilképet, megadhatja a nevét, 
választhat három kaszt közül egyet (harcos, mágus, íjász), illetve választhat egy fegyvert a kasztjához tartozó fegyverek közül. Ezután elkezdődik a játék, baloldalt megjelennek a karakterünk adatai (karakterünk neve, profilkép, életerősáv, kasztunk neve, karakter fegyvere), középen egy kardot ábrázoló gomb, jobboldalt az ellenségünk adatai (az alkalmazás választja ki véletlenszerűen az ellenséget), alul pedig az események olvashatóak. A kardot mintázó gomb megnyomásával felugrik egy kisebb ablak, ami tartalmaz egy kérdést, egy szövegbeviteli mezőt és egy ellenőriz gombot. Helyes válasz esetén csökken az ellenfél életereje, rossz válasz esetén viszont a felhasználó karaktere sebződik. A harc addig tart, amíg az egyik fél életereje 0 nem lesz. Ha legyőztük az ellenfelet, akkor lehetőségünk van folytatni a harcot a Következő ellenfél gomb megnyomásával,
de akár abba is hagyhatjuk a játékot a kilépés gomb használatával. Nem szükséges folyton új karaktert létrehozni, a fő ablak betöltés gombját választva kiválaszthatunk egy korábban létrehozott karaktert, amivel folytathatjuk a játékot.

### Rendszerinformáció:
 
    1. szükséges hardverek:
      - legalább 1.6 GHz-es processzor
      - 1.5 Gb RAM
      - több mint 4 Gb tárhely a merevlemezen a Visual Studio számára
      - DirectX 9 -et támogató videókártya (1024 x 768 vagy ettől nagyobb felbontás)
    2. szükséges szoftverek:
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
* Erőforrások:
     emberi: az alkalmazás elkészítésén 2 fő dolgozik
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
    - a kérdések konténer osztály kidolgozása, a kérdésekhez tartozó adatok beolvasása, helyes válasz ellenőrzése  
        
### Fejlesztés során használt szoftverkomponensek:
  * Visual Studio Community 2015: ingyenesen letölthető tanuló verzió
  * Microsoft Office: ingyenes tanulói verzió
  * GitHub
  * Advanced Installer 13.4: ingyenes verzió
  * Windows operációs rendszer: iskolai ingyenes verzió
  
* Architekturális tervezési minta: Objective Oriented Programming (OOP)
* Változások kezelése: a GitHub verziókövető rendszerrel követjük és vezetjük a változtatásokat

### Rendszer bővíthetősége:
	A rendszer könnyedén bővíthető, kiegészíthető, az OOP elveknek megfelelően íródott. 
	Könnyedén integrálhatunk további kérdéseket is az alkalmazásba a válaszaikkal együtt, így élvezetesebbé téve a programot.
  
### Telepítési terv:
		Az Advanced Installer program használatával egy telepítőfájlt létrehozunk az alkalmazásnak. 
		Ezzel a fájllal bárki könnyedén telepítheti a számítógépére (a kívánt helyre) a szoftvert.
