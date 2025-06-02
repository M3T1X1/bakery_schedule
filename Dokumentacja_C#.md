# Bakery Schedule Manager

**Bakery Schedule Manager** to aplikacja typu Windows Forms napisana w języku C# służąca do zarządzania grafikami pracy pracowników piekarni.

## Spis treści

- [Opis](#opis)
- [Funkcjonalności](#funkcjonalności)
- [Widoki](#widoki)
  - [Widok główny (ScheduleForm)](#widok-główny-scheduleform)
  - [Widok listy pracowników (EmployeeForm)](#widok-listy-pracowników-employeeform)
- [Struktura danych](#struktura-danych)
- [Wymagania](#wymagania)
- [Uruchomienie](#uruchomienie)
- [Baza danych](#baza-danych)
- [Autor](#autor)

---

## Opis

Aplikacja umożliwia dodawanie, edycję oraz usuwanie zmian pracowników, oraz samych pracowników.

## Funkcjonalności

- Zarządzanie grafikami (zmianami) pracowników
- Dodawanie zmian z kontrolą konfliktów czasowych
- Edycja i usuwanie istniejących zmian
- Lista pracowników z możliwością dodawania, edytowania i usuwania
- Obsługa relacji: pracownik — adres, stanowisko, produkt
- Paginacja listy zmian (slider)
- Seeder dzięki któremu mozna zapełnić baze danymi.
## Widoki

### Widok główny (ScheduleForm)

- Lista wszystkich zmian pracowników (`DataGridView`)
- Możliwość dodawania nowej zmiany z wyborem pracownika i datą/godziną
- Sprawdzenie konfliktów zmian w danym dniu lub godzinie
- Edycja i usuwanie wybranej zmiany
- Przycisk do przejścia do listy pracowników
- Paginacja zmian (maksymalnie 2 na stronę, obsługa `TrackBar`)

### Widok listy pracowników (EmployeeForm)

- Wyświetlanie danych pracowników
- Dodawanie nowego pracownika (formularz modalny)
- Edycja danych wybranego pracownika
- Usuwanie pracownika razem z powiązanymi zmianami

### Widok edytowania zmiany (EditScheduleForm)

- Po wybraniu danej zmiany wyświetla się nam formularz edycji
- Mamy listę rozwijana która pobiera pracowników z bazy
- Mamy pole kalendarza dzięki któremu możemy zmienić date zmiany
- Istnieją 2 pola określające czas rozpoczęcia i zakończenia zmiany

### Widok dodawania pracowników (AddEmployeeForm)

- Mamy 4 miejsca na wpisanie danych pracownika: Imie, Nazwisko, Telefon, Lata Doświadczenia
- Pobieramy z bazy danych/list interesujące nas wartości, które przypiszemy danemu pracownikowi: Rodzaj Umowy (lista), Stanowisko, Adres, Produkt
- W sytuacji kiedy pracownik nie jest "Piekarzem", bądź cukiernikiem pole z produktem jest wyłączone i dane nie są zapisywane w bazie danych

### Widok edytowania pracowników (EditEmployeeForm)

- Sytuacja ma się tutaj analogicznie do widoku wyżej, z tą różnicą że tutaj mamy w polu lata doświadczenie pole z wartością liczbową.

### Baza danych (szczegóły techniczne)

Aplikacja korzysta z **SQLite** oraz **Entity Framework Core** do mapowania obiektowo-relacyjnego. Model danych zawiera następujące tabele:

---

#### Tabele

##### `Adres`
Kolumny:  
`ID_adresu`, `Ulica`, `NrMieszkania`, `Klatka`, `Miasto`, `NrDomu`

##### `Produkt`  
Kolumny:  
`ID_produktu`, `Nazwa`, `ŚredniKosztProdukcji`

##### `Stanowisko`  
Kolumny:  
`ID_stanowiska`, `NazwaStanowiska`, `ZarobkiNaGodzine`, `Poziom`, `ID_produktu` *(FK)*

##### `Pracownik`  
Kolumny:  
`ID_pracownika`, `Imie`, `Nazwisko`, `Telefon`, `RodzajUmowy`, `LataDoswiadczenia`,  
`ID_adresu` *(FK)*, `ID_stanowiska` *(FK)*, `ID_produktu` *(FK)*

##### `Zmiana`  
Kolumny:  
`ID_zmiany`, `Data`, `PoczatekZmiany`, `KoniecZmiany`, `Imie`, `Nazwisko`, `ID_pracownika` *(FK)*

---

####  Relacje

- `Pracownik` — `Adres`: **1:N**
- `Pracownik` — `Stanowisko`: **1:N**
- `Pracownik` — `Produkt`: **1:N**
- `Stanowisko` — `Produkt`: **1:N**
- `Pracownik` — `Zmiana`: **1:N**

> Wszystkie relacje wykorzystują `ON DELETE SET NULL`.