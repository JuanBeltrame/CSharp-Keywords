

using System.Runtime.CompilerServices;

PersonaRecord personaRecord01 = new PersonaRecord("Hector", 33);
PersonaRecord personaRecord02 = new PersonaRecord("Hector", 33);

Console.WriteLine(personaRecord01.Nombre);
var personaMasVieja = AumentaEdadPersonaRecord(personaRecord01);
Console.WriteLine(personaRecord01.Edad);
Console.WriteLine(personaMasVieja.Edad);
Console.WriteLine(personaRecord01.Equals(personaRecord02));

static PersonaRecord AumentaEdadPersonaRecord(PersonaRecord persona)
{
    return persona with { Edad = persona.Edad + 1 };
}

//------------------------------------------------------------------------------------

PersonaClase personaClase = new PersonaClase() { Nombre = "Hector", Edad = 33 };

static PersonaClase AumentaEdadPersonaClase(PersonaClase persona)
{
    persona.Edad = persona.Edad + 1; 
    return persona;
}

Console.WriteLine(personaClase.Nombre);
var personaMasViejaClase = AumentaEdadPersonaClase(personaClase);
Console.WriteLine(personaClase.Edad);
Console.WriteLine(personaMasViejaClase.Edad);

record PersonaRecord(string Nombre, int Edad);

public class PersonaClase
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

