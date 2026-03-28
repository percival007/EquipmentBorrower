Żeby włączyć projekt wystarczy odpalić ten projekt w ulubionym IDE i uruchomić metodę main w klasie Program.

Projekt polega na stworzeniu systemu do wypożyczania sprzętu.
Mamy 3 kategorie sprzętów: Laptop, Kamera, Projektor.
Nasz system przyjmuje 2 typy użytkowników: Student i Pracownik.

Próbą zadbania o kohezję jest wydzielenie serwisów na różne dziedziny np. User ma swój własny interfejs, tak samo Rent i Equipment. Każdy z nich skupia się faktycznie na sobie czyli obsłudze swojej logiki biznesowej

Próbą zadbania o coupling jest np. *Repository, dla jakiejkolwiek implementacji repozytorium, czy to będzie statyczne pole imitujące bazę czy faktyczna baza np. Postgres to nie powinno mieć to wpływu na np. serwisy.

Uważan, że podział na persistence jako repozytorium i obsługę logiki biznesowej w serwisach jest odpowiednim rozwiązaniem. Wysoka kohezja i niski coupling.
