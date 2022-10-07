﻿// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.

open System

let suma a b = a + b
let resta a b = a - b
let multiplicacion a b = a * b
let division a b = System.Math.Round(float(a/b),5);

[<EntryPoint>]
let main argv = 
    Console.Write("Introduzca el 1er numero: ")
    let n1 = Convert.ToDouble(Console.ReadLine())
    Console.Write("Introduzca el 2do numero: ")
    let n2 = Convert.ToDouble(Console.ReadLine())
    Console.WriteLine()
    Console.WriteLine("Resultado de las operaciones:")
    Console.WriteLine(" Suma:  "+n1.ToString()+" + "+n2.ToString()+" = "+(suma n1 n2).ToString())
    Console.WriteLine(" Resta:  "+n1.ToString()+" - "+n2.ToString()+" = "+ (resta n1 n2).ToString())
    Console.WriteLine(" Multiplicacion: "+n1.ToString()+" * "+n2.ToString()+" = "+(multiplicacion n1 n2).ToString())
    if (n2 = 0.0) then 
            Console.WriteLine("No existe division entre cero")
        else 
            Console.WriteLine(" Division: "+n1.ToString()+" / "+n2.ToString()+" = "+(division n1 n2).ToString())
    let f = Console.ReadKey()
    0 // devolver un código de salida entero
