import matplotlib.pyplot as plt

ypoints = []


def add_to_graph(num: int) -> None:
    ypoints.append(num)


def show_graph() -> None:
    plt.plot(ypoints, marker='o')
    plt.show()
