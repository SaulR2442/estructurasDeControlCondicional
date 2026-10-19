Console.WriteLine("=== Reporte de Atención Veterinaria ===");

// Variables de entrada

string especieMascota = "perro";   // "perro", "gato", "conejo", "reptil"
int edadMascota = 7;               // edad en años
double peso = 28.5;                // peso en kilogramos
bool tieneVacunasAlDia = false;
bool esSocio = true;
string motivoConsulta = "cirugia"; // "vacuna", "revision", "cirugia", "urgencia"

// Parte 1 — Clasificación por etapa de vida

string etapaVida = edadMascota switch
{
    >= 0 and < 1 => "Cachorro", 
    >= 1 and <= 3 => "Joven",
    >= 4 and <= 8 => "Adulto",
    > 8 => "Senior",
    _ => "Dato incorrecto."
};

Console.WriteLine($"Mascota: {especieMascota} | Edad: {edadMascota} | Etapa: {etapaVida}");

// Parte 2 — Alerta de vacunación

string alertaVacuna;

if ((especieMascota == "perro" || especieMascota == "gato") && tieneVacunasAlDia == true)
{
    alertaVacuna = "Vacunacion al dia";
}
else if ((especieMascota == "perro" || especieMascota == "gato") && tieneVacunasAlDia == false)
{
    alertaVacuna = "ALERTA: Vacunacion urgente requerida";
}
else
{
    alertaVacuna = "Esquema de vacunacion no aplica";
}

Console.WriteLine($"Estado de vacunacion: {alertaVacuna}");

// Parte 3 — Costo base de la consulta

decimal costoBase;
switch (motivoConsulta)
{
    case "vacuna":
        costoBase = 35000;
        break;
    case "revision":
        costoBase = 50000;
        break;
    case "cirugia":
        costoBase = 280000;
        break;
    case "urgencia":
        costoBase = 150000;
        break;
    default:
        costoBase = 0;
        break;

}

Console.WriteLine($"Motivo: {motivoConsulta} | Costo Base: ${costoBase}");

// Parte 4 — Descuento por membresía y peso

double porcentajeDescuento = (esSocio && peso > 25) ? 15.0 : esSocio ? 10.0 : 0.0;

decimal descuento = costoBase * (decimal)(porcentajeDescuento / 100);
decimal costoFinal = costoBase - descuento;

Console.WriteLine($"Descuento: {porcentajeDescuento}% | Costo final: ${costoFinal}.");

// Parte 5 — Recomendación post-consulta

string recomendacion;

if (motivoConsulta == "cirugia")
{
    if (etapaVida == "Senior")
    {
        recomendacion = "Reposo absoluto por 10 días, control post-operatorio obligatorio";
    }
    else
    {
        recomendacion = "Reposo por 5 días, evitar ejercicio intenso";
    }
}
else if (motivoConsulta == "urgencia")
{
    if (tieneVacunasAlDia)
    {
        recomendacion = "Seguimiento en 48 horas";
    }
    else
    {
        recomendacion = "Atender urgencia y programar vacunación inmediata";
    }
}
else
{
    recomendacion = "Seguimiento en próxima consulta de rutina";
}

Console.WriteLine($"Recomendacion: {recomendacion}");

/*

Salida esperada completa

=== Reporte de Atención Veterinaria ===
Mascota: perro | Edad: 7 años | Etapa: Adulto
Estado de vacunación: ALERTA: vacunación urgente requerida
Motivo: cirugia | Costo base: $280.000
Descuento: 15% | Costo final: $238.000
Recomendación: Reposo por 5 días, evitar ejercicio intenso

*/
