import pygal

from 骰子.die import Die

# 创建 3 个 D8
die_1 = Die(8)
die_2 = Die(8)
die_3 = Die(8)

nums = 10000;
results = []

for roll_num in range(nums):
    result = die_1.roll() + die_2.roll() + die_3.roll()
    results.append(result)

frequencies = []
max_results = die_1.num_sides + die_2.num_sides + die_3.num_sides
for value in range(3, max_results+1):
    # 计算某个值出现同样的次数
    frequency = results.count(value)
    frequencies.append(frequency)

# 对结果进行可视化
hist = pygal.Bar()

hist.title = "Results of rolling two D6 dice 1000 times."
hist.x_labels = [str(num) for num in range(3, max_results+1)] #['1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12']
hist.x_title = "Result"
hist.y_title = "Frequency of Result"

hist.add('D8 * 3', frequencies)
hist.render_to_file('images/dice3_visual.svg')