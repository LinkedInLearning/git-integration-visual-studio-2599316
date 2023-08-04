# Git-Integration in Visual Studio

Dies ist das Repository für den **LinkedIn Learning** Kurs `Git-Integration in Visual Studio`. Den gesamten Kurs finden Sie auf [LinkedIn Learning][lil-course-url].

![COURSENAME][lil-thumbnail-url]

Git ist seit Jahren das beliebteste Versionsverwaltungssystem und kommt in Softwareprojekten jeder Größe und auf vielen verschiedenen Plattformen zum Einsatz. Durch die Integration in die mächtige Entwicklungsumgebung Visual Studio kann es seine Vorteile noch besser ausspielen, ganz egal, ob Sie noch Programmieren lernen oder schon ein/e erfahrene/r Softwareentwickler: in sind.

Im Laufe seines Praxiskurses erläutert André Kräemer Schritt für Schritt die Bedienung von Git anhand eines durchgängigen Beispiels: Sie beginnen mit den grundlegenden Befehlen, um mit einem lokalen Repository zu arbeiten. Danach erforschen Sie die Versionshistorie, entdecken, was Branching und Merging bedeuten, und sehen auch, wie Sie mit Merge-Konflikten umgehen können. Zum Abschluss steht das Zusammenspiel von GitHub und AzureDevOps im Mittelpunkt.


## Anleitung

Dieses Repository entspricht dem Demo-Repositorry des Kurses. Sie können die einzelnen Zustände des Kurses sowohl über die Commit Historie, als auch über die Branch-Liste nachvollziehen.

## Branches

Im Gegensatz zu anderen Kursen sind die Git Branches nicht passend zu den Videos im Kurs strukturiert. Es gibt also keine Branches nach der Namenskonvention `Kapitel#_Video#`. Der Grund hierfür ist, dass dies kein Programmierkurs ist sich die gängige Branchstruktur daher nicht geeignet hat.

Die Branches dienen lediglich als Anschauungsobjekt für den Kurs.

Wenn Sie von einem Branch nach Änderungen zum nächsten Branch wechseln, erhalten Sie möglicherweise die folgende Meldung:

```
error: Your local changes to the following files would be overwritten by checkout:        [files]
Please commit your changes or stash them before you switch branches.
Aborting
```

Dieses Problem lösen Sie wie folgt:
    Add changes to git using this command: git add .
    Commit changes using this command: git commit -m "some message"

## Installation

1. Um diesem Kurs praktisch folgen zu können, müssen Sie folgendes installiert haben:
   - Visual Studio 2022 Update 17.5 oder höher


### Autor

**André Krämer**

_Geschäftsführer der Quality Bytes GmbH_

Sehen Sie sich andere Kurse des Autors auf [LinkedIn Learning](https://www.linkedin.com/learning/instructors/andre-kramer) an.

[0]: # (Replace these placeholder URLs with actual course URLs)
[lil-course-url]: https://www.linkedin.com/learning/git-integration-in-visual-studio
[lil-thumbnail-url]: https://media.licdn.com/dms/image/D4E0DAQFYbOU2GM0Jgg/learning-public-crop_675_1200/0/1684239401711?e=2147483647&v=beta&t=hO0hhqWHFUaTlBkcGW0qUD3yGmOkny65dx6VdlEOYnQ
