from point_graph import add_to_graph, show_graph


def print_data(number_series: list) -> None:
    print(f"the avrage of the numbers is {avg(number_series)}")
    print(f"there are {positive_number_count(number_series)} positive numbers")
    print(f"the sorted series -> {sorted(number_series)}")
    show_graph()


def get_input_and_add_to_list(number_series: list) -> None:
    num = input("enter the numbers for the series, enter -1 to finish: ")
    while num != '-1':
        number_series.append(int(num))
        add_to_graph(int(num))
        num = input()
    print_data(number_series)


def avg(number_series: list) -> float:
    sum = 0
    for num in number_series:
        sum += num
    return sum / len(number_series)


def positive_number_count(number_series: list) -> int:
    positive_counter = 0
    for num in number_series:
        if num >= 0:
            positive_counter += 1
    return positive_counter


if __name__ == "__main__":
    num_series = []
    get_input_and_add_to_list(num_series)

