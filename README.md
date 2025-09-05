
# 🏦 Cajero Automático en C#

Este proyecto es una simulación básica de un cajero automático desarrollada en C#. Permite al usuario consultar su saldo, consignar dinero, retirar dinero y salir del sistema. Es ideal para principiantes que están aprendiendo estructuras de control, entrada/salida por consola y tipos de datos como `decimal`.

## 🚀 Características

- Consulta de saldo actual
- Consignación de dinero
- Retiro de dinero con validación de saldo
- Menú interactivo en consola
- Ciclo de ejecución hasta que el usuario decida salir

## 📋 Requisitos

- [.NET SDK](https://dotnet.microsoft.com/en-us/download) instalado
- Editor de código como Visual Studio, Visual Studio Code o cualquier IDE compatible con C#

## 🧠 Lógica del Programa

El programa inicia con un saldo predeterminado de **1,000,000**. Luego, muestra un menú con las siguientes opciones:

1. **Consultar saldo**: Muestra el saldo actual.
2. **Consignar dinero**: Solicita un monto y lo suma al saldo.
3. **Retirar dinero**: Solicita un monto y lo resta del saldo si hay fondos suficientes.
4. **Salir**: Finaliza el programa.

El menú se repite hasta que el usuario elige la opción 4.

## 🛠️ Cómo ejecutar

1. Clona este repositorio o copia el código en un archivo llamado `Program.cs`.
2. Abre una terminal en el directorio del archivo.

3. Ejecuta el programa con:

   ```bash
   dotnet run
   ```

## 📦 Ejemplo de uso

```
Cajero Automático
1. Consultar saldo
2. Consignar dinero
3. Retirar dinero
4. Salir
Elige una opción: 1
Tu saldo actual es: 1000000
```



