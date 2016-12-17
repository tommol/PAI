# PAI
Projekt na Programowanie Aplikacji internetowych

1. Struktura projektu

Projekt (Solucja SLN) składa się z wielu projektów. 
* pl.lodz.p.ftims.edu.pai.admin 
  Aplikacja kliencka dla centrali, docelowo w technologii WinForms
* pl.lodz.p.ftims.edu.pai.branch
  WebService dla oddziału
* pl.lodz.p.ftims.edu.pai.branch.dal
  Warstwa dostepu do danych dla oddziału
* pl.lodz.p.ftims.edu.pai.branch.dto
  Obiekty transferowe klient oddziału <-> WebService Oddziału
* pl.lodz.p.ftims.edu.pai.branch.entity
  Obiekty encyjne dla oddziału 
* pl.lodz.p.ftims.edu.pai.central
  WebService dla centrali
* pl.lodz.p.ftims.edu.pai.central.dal
  Warstwa dostepu do danych dla centrali
* pl.lodz.p.ftims.edu.pai.central.dto
  Obiekty transferowe Klient Centrali <-> Serwis centrali
* pl.lodz.p.ftims.edu.pai.central.entity
  Obiekty encyjne dla centrali
