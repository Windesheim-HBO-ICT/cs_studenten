
using GrafischProgramma;

Model model = new Model();

ThreeDimensionalViewer scherm1 = new ThreeDimensionalViewer(model) { Name = "Scherm 1"};
ThreeDimensionalViewer scherm2 = new ThreeDimensionalViewer(model) { Name = "Scherm 2"};
ThreeDimensionalViewer scherm3 = new ThreeDimensionalViewer(model) { Name = "Scherm 3"};

model.Getal = 4;


Console.WriteLine("\n\n\n------------------\n\n\n");

//De volgende code is alleen werkzaam wanneer de opmerking in de hackviewer klasse opvolging heeft gekregen.
//Het hack-voorbeeld gaat in op het nut van het sleutelwoord event. Het sleutelwoord 'event' zorgt voor encapsulation, hierdoor kan alleen nog binnen de klasse van het event de operator = gebruikt worden om aan het delegate object een handler toe te kennen.
HackViewer hackViewer = new HackViewer(model);

model.Getal = 999;



