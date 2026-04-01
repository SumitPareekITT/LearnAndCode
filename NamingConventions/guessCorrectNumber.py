import random

def valid_number(text):
    if not text.isdigit():
        return False
    value = int(text)
    return 1 <= value <= 100


def start_game():
    target = random.randint(1, 100)
    tries = 0

    guess_text = input("Pick a number from 1 to 100: ")

    while True:
        if not valid_number(guess_text):
            guess_text = input("Invalid entry! Choose a number 1-100: ")
            continue

        guess_num = int(guess_text)
        tries += 1

        if guess_num < target:
            guess_text = input("Too small! Guess again: ")
        elif guess_num > target:
            guess_text = input("Too big! Guess again: ")
        else:
            print(f"Nice! You got it in {tries} tries.")
            break


if __name__ == "__main__":
    start_game()
