def pythagorean_triplet_by_sum(sum: int) -> None:
    for a in range(1, int(sum / 3) + 1):
        for b in range(a + 1, int(sum / 2) + 1):
            c = sum - a - b
            if a ** 2 + b ** 2 == c ** 2:
                print(f"{a}, {b}, {c}")


if __name__ == "__main__":
    pythagorean_triplet_by_sum(120)
