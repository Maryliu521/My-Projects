number = int(raw_input("give me a number: "))
if (number%3 == 0) and (number%5 == 0):
    print("Fizz Buzz")
elif (number%3) == 0:
    print("Fizz")
elif (number%5) == 0:
    print("Buzz")
else:
    print("Please enter another number.")

