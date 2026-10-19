# Ejercicios de Estructuras de Control Condicional en C#

Este proyecto contiene la solución a dos ejercicios prácticos en C# enfocados en dominar el uso de las distintas estructuras de control condicional: `if-else`, operador ternario, `switch` tradicional y `switch expressions`.

## 1. Taller control condicional

**Objetivo:** Implementar una función que determine si un número es positivo, negativo o cero.

**Descripción:**
Se implementa la función `CheckNumber` que recibe un número entero como parámetro y devuelve un mensaje en formato string indicando su signo. 

**Lógica implementada:**
Se utilizó la estructura de control `if-else if-else` para cubrir las tres condiciones matemáticas posibles:
- Número `> 0` $\rightarrow$ "El número es positivo"
- Número `< 0` $\rightarrow$ "El número es negativo"
- Número `== 0` $\rightarrow$ "El número es cero"

---

## 2. Reto: Sistema de atención en una clínica veterinaria

**Objetivo:** Aplicar todas las estructuras de control condicional de C# dentro de un programa continuo que simula el flujo de atención de una mascota en una clínica.

**Descripción:**
El sistema procesa los datos de entrada de una mascota (especie, edad, peso, esquema de vacunas, estado de membresía del dueño y motivo de consulta) para tomar decisiones encadenadas y generar un reporte de atención final.

### Estructura de la Solución

*   **Parte 1 — Clasificación por etapa de vida:** 
    Determina si la mascota es "Cachorro", "Joven", "Adulto" o "Senior" evaluando la edad mediante una **`switch expression`** utilizando coincidencia de patrones lógicos y de rangos (`>=`, `<`, `and`).
*   **Parte 2 — Alerta de vacunación:** 
    Verifica si se trata de un perro o gato y si requiere vacunas urgentes. Se resuelve usando condicionales **`if-else`** combinados con operadores lógicos AND (`&&`), OR (`||`) y NOT (`!`).
*   **Parte 3 — Costo base de la consulta:** 
    Asigna un valor económico base dependiendo del motivo de la consulta usando un **`switch` tradicional** con sus respectivos `case`, `break` y valor `default`.
*   **Parte 4 — Descuento por membresía y peso:** 
    Calcula el porcentaje de descuento aplicable (15%, 10% o 0%) evaluando si el cliente es socio y el peso de la mascota mediante un **operador ternario anidado** (`condicion ? valor_si_verdadero : valor_si_falso`).
*   **Parte 5 — Recomendación post-consulta:** 
    Genera instrucciones médicas al final del reporte evaluando el motivo de la consulta combinado con variables previas (como etapa de vida o vacunación) utilizando estructuras **`if-else` anidadas**.

### Salida Esperada (Ejemplo)
```text
=== Reporte de Atención Veterinaria ===
Mascota: perro | Edad: 7 años | Etapa: Adulto
Estado de vacunación: ALERTA: vacunación urgente requerida
Motivo: cirugia | Costo base: $280.000
Descuento: 15% | Costo final: $238.000
Recomendación: Reposo por 5 días, evitar ejercicio intenso