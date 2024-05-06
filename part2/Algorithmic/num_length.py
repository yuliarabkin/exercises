import math


def num_len(num: int):
    return int(math.log10(num)) + 1


if __name__ == "__main__":
    print(num_len(38968))
