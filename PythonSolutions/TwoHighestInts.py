def largest_pair_sum(numbers):
    numbers.sort(reverse=True)
    return numbers[0] + numbers[1]
    #return sum(sorted(numbers)[-2:])

largest_pair_sum([10,14,2,23,19])