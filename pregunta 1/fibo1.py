# -*- coding: utf-8 -*-
"""
Created on Mon Jun 13 23:58:00 2022

@author: carlos
"""

#Program to generate Fibonacci sequence recursively 
def Fibonacci(n):
    if(n==0):
        return 0
    elif(n==1):
        return 1
    else:
        return (Fibonacci(n-2)+Fibonacci(n-1))
n=int(input(" valor  Recursivo"))
for i in range(n):
    print( Fibonacci(i))

def fbn(n):
    a = 1
    b = 1
    c = 0
    
    if (n == 1):
       return 1
    if (n == 2):
      return 1

    for i in range(2,n) :
        c = a + b
        a = b
        b = c 
    return c
 
n=int(input(" valor Estructurado"))
for i in range(n):
    print( fbn(i))
    