def is_sorted_polyndrom(string: str) -> bool:
    if is_polyndrom(string):
        for x in range(len(string) // 2):
            if string[x] > string[x + 1]:
                return False
        return True
    return False


def is_polyndrom(string: str) -> bool:
    return string == string[::-1]


if __name__ == "__main__":
    print(is_sorted_polyndrom("abcdcba"))
