// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System
let rec fibo n = if n <=2 then 1 else fibo (n - 1) + fibo (n - 2)
let  fibo1 n =
    let mutable a=1
    let mutable b=1
    let mutable c=0
    if n=1 then 1 
    elif n=2 then 1 
    else 
    for i in 3..n do
       c<-a+b
       a<-b
       b<-c
   
    c 
 
 
[<EntryPoint>]
let main argv = 
    Console.WriteLine("sig recursiva")
    let num=Console.ReadLine()
    let val1=Convert.ToInt32(num)
    for i in 1..val1 do
      Console.WriteLine(fibo(i))

    Console.WriteLine("sig estrutura")
    let num2=Console.ReadLine()
    let val2=Convert.ToInt32(num2)
    for i in 1..val2 do
      Console.WriteLine(fibo1(i))
    printfn "%A" argv
    let tecla=Console.ReadKey()
    0 // return an integer exit code
