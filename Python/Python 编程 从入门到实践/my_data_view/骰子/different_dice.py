import pygal

from 骰子.die import Die

# 创建一个 D6 和 D10
die_1 = Die()
die_2 = Die(10)

results = []
for roll_num in range(5000):
    result = die_1.roll() + die_2.roll()
    results.append(result)

frequencies = []
max_results = die_1.num_sides + die_2.num_sides
for value in range(2, max_results+1):
    # 计算某个值出现同样的次数
    frequency = results.count(value)
    frequencies.append(frequency)

# 对结果进行可视化
hist = pygal.Bar()

hist.title = "5000 次：D6 + D10 的结果。"
hist.x_labels = [str(num) for num in range(2, 17)]
hist.x_title = "结果"
hist.y_title = "重复出现的次数"

hist.add('D6 + D10', frequencies)
hist.render_to_file('images/different_visual.svg')