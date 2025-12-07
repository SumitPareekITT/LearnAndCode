def calculate_armstrong_sum(number):
    total = 0
    digits = len(str(number))
    tempNumber = number

    while tempNumber > 0:
        lastDigit = tempNumber % 10
        total += lastDigit ** digits
        tempNumber //= 10

    return total

value = int(input("Enter a number to verify Armstrong property: "))

result = calculate_armstrong_sum(value)

if value == result:
    print(value, "is an Armstrong number.")
else:
    print(value, "is NOT an Armstrong number.")