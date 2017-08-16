import pygal

from 骰子.die import Die

# 创建 2 个 D6
die_1 = Die()
die_2 = Die()

results = []
for roll_num in range(1000):
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

hist.title = "D6 100次："
hist.x_labels = [str(num) for num in range(1, 13)] #['1', '2', '3', '4', '5', '6', '7', '8', '9', '10', '11', '12']
hist.x_title = "结果"
hist.y_title = "出现的次数"

hist.add('D6 + D6', frequencies)
hist.render_to_file('images/dice_visual.svg')