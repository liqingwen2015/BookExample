import pygal

from 骰子.die import Die

# 创建一个 D6
die = Die()

results = []
for roll_num in range(1000):
    result = die.roll()
    results.append(result)

frequencies = []
for value in range(1, die.num_sides+1):
    # 计算某个值出现同样的次数
    frequency = results.count(value)
    frequencies.append(frequency)

# 对结果进行可视化
hist = pygal.Bar()

hist.title = "D6 1000次："
hist.x_labels = [str(num) for num in range(1, 7)] #['1', '2', '3', '4', '5', '6']
hist.x_title = "结果"
hist.y_title = "出现的次数"

hist.add('D6', frequencies)
hist.render_to_file('images/die_visual.svg')