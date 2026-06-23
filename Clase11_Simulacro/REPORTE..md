# REPORTE DE AUDITORÍA Y REFACTORIZACIÓN

## Simulacro de Examen Bimestral – Clase 11

### Hallazgo 1: Falta de validación en PuntoDeRed

**Clase afectada:** PuntoDeRed

**Severidad:** Alta

**Problema detectado:**
La clase permite almacenar coordenadas inválidas como latitud = 500 y longitud = -999.

**Tema utilizado para corregirlo:**

* Clase 5: Encapsulamiento
* Clase 9: Manejo de Excepciones

**Corrección aplicada:**
Se agregaron validaciones mediante `ArgumentOutOfRangeException` para garantizar que la latitud se encuentre entre -90 y 90 grados y la longitud entre -180 y 180 grados.

**Justificación técnica:**
La validación temprana evita que el sistema almacene información inconsistente y sigue el principio Fail Fast visto en la Clase 9.

---

### Hallazgo 2: Modelado incorrecto de PuntoDeRed

**Clase afectada:** PuntoDeRed

**Severidad:** Media

**Problema detectado:**
La ubicación fue implementada como una clase mutable.

**Tema utilizado para corregirlo:**

* Clase 4: Clases y Objetos
* Clase 11: Structs y Value Types

**Corrección aplicada:**
Se reemplazó la clase por un `struct` con propiedades de solo lectura.

**Justificación técnica:**
Las coordenadas representan datos simples que no requieren comportamiento complejo y se benefician de la semántica de copia de los Value Types.

---

### Hallazgo 3: Encapsulamiento roto en ServidorConexion

**Clase afectada:** ServidorConexion

**Severidad:** Alta

**Problema detectado:**
Los atributos estaban expuestos públicamente.

**Tema utilizado para corregirlo:**

* Clase 5: Encapsulamiento

**Corrección aplicada:**
Se reemplazaron campos públicos por propiedades controladas.

**Justificación técnica:**
El encapsulamiento protege la integridad interna del objeto y reduce modificaciones no controladas.

---

### Hallazgo 4: Fibonacci ineficiente

**Clase afectada:** ServidorConexion

**Severidad:** Alta

**Problema detectado:**
El método DiagnosticarLatencia utilizaba recursión pura.

**Tema utilizado para corregirlo:**

* Clase 3: Métodos y Recursividad
* Clase 11: Memoization y Optimización Algorítmica

**Corrección aplicada:**
Se implementó Memoization mediante un arreglo de caché.

**Justificación técnica:**
La complejidad pasó de O(2ⁿ) a O(n), reduciendo drásticamente el tiempo de ejecución.

---

### Hallazgo 5: Ausencia de manejo de excepciones

**Clase afectada:** Program

**Severidad:** Alta

**Problema detectado:**
El programa no controlaba errores de entrada o valores inválidos.

**Tema utilizado para corregirlo:**

* Clase 9: Manejo de Excepciones y Depuración

**Corrección aplicada:**
Se implementaron bloques `try-catch` para capturar errores de formato y rango.

**Justificación técnica:**
Permite que la aplicación continúe funcionando de manera controlada ante errores del usuario.

---

### Hallazgo 6: Falta de consultas sobre la colección

**Clase afectada:** Program

**Severidad:** Media

**Problema detectado:**
No existía mecanismo para filtrar servidores críticos.

**Tema utilizado para corregirlo:**

* Clase 8: Colecciones Genéricas
* Clase 8: LINQ

**Corrección aplicada:**
Se implementó una consulta LINQ utilizando `Where()` y `Contains()`.

**Justificación técnica:**
LINQ mejora la legibilidad del código y permite consultas declarativas sobre colecciones.

Conceptos aplicados del curso:

Clases y Objetos
Encapsulamiento
Structs y Value Types
Reference Types
Colecciones Genéricas (List<T>)
LINQ
Recursividad
Memoization
Manejo de Excepciones
Git Flow
Refactorización y Auditoría de Código