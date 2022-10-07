def suma( num1 , num2 ):
  return int(num1 + num2)

def resta( num1 , num2 ):
  return num1 - num2

def multi( num1 , num2 ):
  return num1 * num2

def div( num1 , num2 ):
  return num1 / num2


num1 = int(input("Ingrese el primer numero: "))
num2 = int(input("Ingrese el primer numero: "))
print("")

#resp = int (suma(num1, num2))
print(f"La suma es :   {int (suma(num1, num2))}")
print("")

print(f"La resta es :   {int (resta(num1, num2))}")
print("")

print(f"La multiplicacion es :{int (multi(num1, num2))}")
print("")

print(f"La division es :   {float (div(num1, num2))}")
print("")