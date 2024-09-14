import math
import numpy as np

num = [100, 80, 75, 77, 89, 33, 45, 25, 65, 17, 30, 24, 57, 55, 70, 75, 65, 84, 90, 15]
sorted_num = sorted(num)
mean_value = sum(num)/len(num)
num_deviation = [(i-mean_value)**2 for i in num]
d_x = sum(num_deviation)/len(num)
sqrt_d_x = d_x ** 0.5
# sqrt_d_x_1 = math.sqrt(d_x)
biased_variance = d_x
unbiased_variance = sum(num_deviation)/(len(num)-1)

# print(num_deviation)
# print(sorted_num)
print("среднее значение: ", mean_value)
print("дисперсия: ", d_x)
print("среднее квадратическое отклонение: ", sqrt_d_x)
print("смещенная дисперсия: ", biased_variance)
print("несмещенная дисперсия: ",unbiased_variance)

# P = 1/3 * 0.1 + 1/3 * 0.2 + 1/3 * 0.25  
# P1 = 0.1 * 1/3 / P * 0.2 * 1/3 / P * 0.25 *1/3 / P 
# # a = 0.9 * 1/3  / P
# # b = 0.8 * 1/3  / P
# # c = 0.6 * 1/3  / P
# print(P, P1)
