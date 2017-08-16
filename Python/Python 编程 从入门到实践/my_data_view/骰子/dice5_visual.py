import pygal
import matplotlib.pyplot as plt

from 骰子.die import Die

# 创建 2 个 D6
die_1 = Die()
die_2 = Die()

nums = 10;
results = []

for roll_num in range(nums):
    result = die_1.roll() * die_2.roll()
    results.append(result)

frequencies = []
max_results = die_1.num_sides * die_2.num_sides
for value in range(1, max_results+1):
    # 计算某个值出现同样的次数
    frequency = results.count(value)
    frequencies.append(frequency)

plt.plot([str(num) for num in range(1, max_results+1)], frequencies, linewidth=5)

# 设置图表标题，并给坐标轴加上标签
plt.title("10000 times:", fontsize=24)
plt.xlabel("Resulst", fontsize=14)
plt.ylabel("frequency", fontsize=14)

# 设置刻度标记的大小，axis='both' 表示指定的实参影响 x 轴和 y 轴上的刻度
plt.tick_params(axis='both', labelsize=14)

plt.show()