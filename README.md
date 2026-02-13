# Ticket Management API - DevOps Projekt Zaliczeniowy

Prosta aplikacja webowa napisana w **.NET 8**, stworzona na potrzeby projektu zaliczeniowego z przedmiotu Cykl ¿ycia i narzêdzia DevOps. Projekt demonstruje pe³en cykl ¿ycia oprogramowania: od kodowania, przez automatyczne testowanie (CI), a¿ po ci¹g³e wdra¿anie do chmury (CD).

## Funkcjonalnoœci

Aplikacja symuluje system do zarz¹dzania biletami na wydarzenia. Dostêpne s¹ nastêpuj¹ce endpointy:

* `GET /` - Strona powitalna API.
* `GET /products` - Zwraca listê dostêpnych biletów w formacie JSON (zasilane przez `TicketService`).
* `GET /swagger` - Dokumentacja API (dostêpna wy³¹cznie w œrodowisku deweloperskim).

## Technologie

* **Jêzyk i framework:** C#, .NET 8
* **Testy jednostkowe:** xUnit
* **Dokumentacja API:** Swagger / OpenAPI
* **CI/CD:** GitHub Actions
* **Hosting:** Azure App Service (Linux)

## Automatyzacja (CI/CD Pipeline)

Projekt zawiera w pe³ni skonfigurowane procesy Continuous Integration oraz Continuous Delivery za pomoc¹ **GitHub Actions**.

1.  **CI Pipeline (`.NET CI`)** * Wyzwalany automatycznie przy ka¿dym `push` i `pull_request` na ga³êzie `main`, `master` oraz `testy-jednostkowe`.
    * Kroki: Przywracanie pakietów (Restore) ?? Budowanie (Build) ?? Uruchomienie testów jednostkowych (Test).
2.  **CD Pipeline (`CD Pipeline - Deploy to Azure`)**
    * Wyzwalany automatycznie po pomyœlnym zakoñczeniu procesu CI na ga³êzi `master`.
    * Kroki: Budowanie wersji produkcyjnej (Publish) ?? Wdro¿enie gotowej paczki do **Azure App Service** (aplikacja: `ticket-management-sonulski`).

## Uruchomienie lokalne

Aby uruchomiæ projekt na swoim komputerze, wykonaj poni¿sze kroki w terminalu:

1.  Pobierz repozytorium:
    ```bash
    git clone <link-do-repozytorium>
    ```
2.  PrzejdŸ do folderu z projektem:
    ```bash
    cd DevOps-projekt-zaliczeniowy
    ```
3.  Zbuduj i uruchom aplikacjê:
    ```bash
    dotnet run
    ```
4.  Otwórz przegl¹darkê i przejdŸ pod adres, który pojawi siê w terminalu (np. `http://localhost:5262`).

Aby uruchomiæ testy jednostkowe:
```bash
dotnet test

## Uruchomienie zdalne

Aby uruchomiæ aplikacjê zdalnie nale¿y wejœæ pod adres: (`https://ticket-management-sonulski.azurewebsites.net/`).