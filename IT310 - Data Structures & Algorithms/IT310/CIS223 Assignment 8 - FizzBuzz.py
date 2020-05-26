def fizzbuzz(n):
    fizz = False
    buzz = False

    if n % 3 == 0:

        fizz = True

    if n % 5 == 0:

        buzz = True

    if fizz == True and buzz == True:

        return "FizzBuzz"

    elif fizz == True and buzz == False:

        return "Fizz"

    elif fizz == False and buzz == True:

        return "Buzz"

    else:

        return str(n)

if __name__ == "__main__":
    print(fizzbuzz(5))
    print(fizzbuzz(3))
    print(fizzbuzz(15))
    print(fizzbuzz(7))
    print(fizzbuzz(0))