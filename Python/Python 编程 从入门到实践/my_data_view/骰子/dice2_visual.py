import pygal

from 骰子.die import Die

# 创建两个 D8
die_1 = Die(8)
die_2 = Die(8)

nums = 1000;
results = []

while True:
    for roll_num in range(nums):
        result = die_1.roll() + die_2.roll()
        results.append(result)

    frequencies = []
    max_results = die_1.num_sides + die_2.num_sides
    for value in range(2, max_results+1):
        # 计算某个值出现同样的次数
        frequency = results.count(value)
        frequencies.append(frequency)

    nums *= 100
    print(nums)

# 对结果进行可视化
hist = pygal.Bar()

hist.title = "Results of rolling two D6 dice 1000 times."
hist.x_labels = [str(num) for num in range(1, 13)] #['1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12']
hist.x_title = "Result"
hist.y_title = "Frequency of Result"

hist.add('D6 + D6', frequencies)
hist.render_to_file('dice_visual.svg')