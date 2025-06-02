# Bakery Schedule Manager

**Bakery Schedule Manager** to aplikacja typu Windows Forms napisana w języku C# służąca do zarządzania grafikami pracy pracowników piekarni.

## Spis treści

- [Opis](#opis)
- [Funkcjonalności](#funkcjonalności)
- [Widoki](#widoki)
  - [Widok główny (ScheduleForm)](#widok-główny-scheduleform)
  - [Widok listy pracowników (EmployeeForm)](#widok-listy-pracowników-employeeform)
  - [Widok edytowania zmiany (EditScheduleForm)](#widok-edytowania-zmiany-editscheduleform)
  - [Widok dodawania pracowników (AddEmployeeForm)](#widok-dodawania-pracowników-addemployeeform)
  - [Widok edytowania pracowników (EditEmployeeForm)](#widok-edytowania-pracowników-editemployeeform)
- [Baza danych](#baza-danych-szczegóły-techniczne)
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
- Seeder dzięki któremu można zapełnić bazę danymi

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

- Po wybraniu danej zmiany wyświetla się formularz edycji
- Lista rozwijana pobierająca pracowników z bazy
- Pole kalendarza do zmiany daty zmiany
- Dwa pola określające czas rozpoczęcia i zakończenia zmiany

### Widok dodawania pracowników (AddEmployeeForm)

- Cztery pola do wpisania danych: Imię, Nazwisko, Telefon, Lata doświadczenia
- Listy rozwijane do przypisania: Rodzaju umowy, Stanowiska, Adresu, Produktu
- Gdy pracownik nie jest piekarzem/cukiernikiem, pole „Produkt” jest nieaktywne

### Widok edytowania pracowników (EditEmployeeForm)

- Jak w widoku dodawania, ale z możliwością modyfikacji wartości liczbowych w polu „Lata doświadczenia”

## Baza danych (szczegóły techniczne)

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

#### Relacje

- `Pracownik` — `Adres`: **1:N**
- `Pracownik` — `Stanowisko`: **1:N**
- `Pracownik` — `Produkt`: **1:N**
- `Stanowisko` — `Produkt`: **1:N**
- `Pracownik` — `Zmiana`: **1:N**

> Wszystkie relacje wykorzystują `ON DELETE SET NULL`.

## Autor

Autor: Kacper Dusza