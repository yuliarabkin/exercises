import math


def reverse_n_pi_digits(num: int) -> str:
    reversed_pi = str(math.pi)[num::-1]
    return reversed_pi


if __name__ == "__main__":
    print(math.pi)
    print(reverse_n_pi_digits(4))
