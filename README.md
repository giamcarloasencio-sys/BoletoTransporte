# BoletoTransporte 
# Sistema de Boletos de Transporte 🚍

## Descripción del proyecto

Este proyecto consiste en un programa desarrollado en C# que permite generar boletos de transporte de manera sencilla. El usuario puede introducir el nombre del pasajero, seleccionar un destino y elegir el tipo de transporte que desea utilizar.

El sistema calcula automáticamente el precio del viaje y el tiempo aproximado que tardará en llegar al destino. Finalmente, muestra un boleto con los datos del pasajero y del viaje.

## Tecnologías utilizadas

- **Lenguaje:** C#
- **Plataforma:** .NET
- **Tipo de aplicación:** Consola
- **Entorno de desarrollo:** Visual Studio Community

## Destinos disponibles

El programa cuenta con cinco destinos:

| Opción | Destino | Distancia |
|---|---|---:|
| 1 | San Pedro de Macorís | 70 km |
| 2 | La Romana | 115 km |
| 3 | Santiago | 155 km |
| 4 | Punta Cana | 190 km |
| 5 | Puerto Plata | 210 km |

## Tipos de transporte

| Opción | Transporte | Precio por km | Velocidad promedio |
|---|---|---:|---:|
| 1 | Autobús | RD$ 3.50 | 60 km/h |
| 2 | Minibús | RD$ 4.50 | 70 km/h |
| 3 | Taxi | RD$ 25.00 | 80 km/h |

## Funcionalidades

- Solicitar el nombre del pasajero.
- Mostrar los destinos disponibles y sus distancias.
- Permitir la selección del tipo de transporte.
- Validar las opciones introducidas por el usuario.
- Calcular el precio total del viaje.
- Calcular el tiempo aproximado de recorrido en horas y minutos.
- Generar un número aleatorio para el boleto.
- Mostrar la fecha y hora actuales.
- Imprimir el boleto con todos los datos del viaje.

## Fórmulas utilizadas

**Cálculo del precio:**

Precio = Distancia × Costo por kilómetro

**Cálculo del tiempo:**

Tiempo = Distancia ÷ Velocidad promedio

## Conceptos de programación aplicados

Durante el desarrollo del proyecto se utilizaron los siguientes conceptos básicos de programación:

- Variables y tipos de datos.
- Entrada y salida de información con `Console.ReadLine()` y `Console.WriteLine()`.
- Condicionales mediante `if`.
- Estructuras de selección `switch`.
- Ciclos `do-while`.
- Métodos para organizar el código.
- Validación de datos con `int.TryParse()`.
- Generación de números aleatorios con `Random`.
- Operaciones matemáticas y conversiones de datos.
- Uso de `DateTime.Now` para obtener la fecha y hora actuales.

## Cómo ejecutar el programa

1. Abrir Visual Studio Community.
2. Crear un proyecto de tipo **Aplicación de consola en C#**.
3. Copiar el código fuente en el archivo `Program.cs`.
4. Ejecutar el proyecto utilizando `Ctrl + F5`.
5. Introducir el nombre del pasajero.
6. Seleccionar el destino y el tipo de transporte.
7. Consultar el boleto generado en la consola.


CAPTURAS DE PANTALLA 

<img width="1919" height="997" alt="Captura de pantalla 2026-10-19 220306" src="https://github.com/user-attachments/assets/67fcc46a-2369-476d-839e-6ec2163adba2" />

<img width="1919" height="996" alt="Captura de pantalla 2026-10-19 220213" src="https://github.com/user-attachments/assets/2e69dcdc-94b2-414a-8ade-1823af95405d" />

<img width="1919" height="999" alt="Captura de pantalla 2026-10-19 220627" src="https://github.com/user-attachments/assets/11de4c82-a84b-4596-acb5-51f11dbd50eb" />

