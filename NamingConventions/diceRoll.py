import random

def throw_die(sides):
    return random.randint(1, sides)

def main():
    sidesOfDice = 6
    keepRolling = True

    while keepRolling:
        userInput = input("Press ENTER to roll, or Q to Quit: ")

        if userInput.lower() != "q":
            rolledNumber = throw_die(sidesOfDice)
            print("You rolled a", rolledNumber)
        else:
            keepRolling = False

main()