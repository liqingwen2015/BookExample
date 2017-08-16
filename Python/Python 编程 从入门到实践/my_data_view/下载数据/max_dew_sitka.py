import csv

from matplotlib import pyplot as plt
from datetime import datetime

filename='sitka_weather_2014.csv'
with open(filename) as f:
    reader = csv.reader(f)
    head_row = next(reader)

    date_times, max_dews = [], []
    for row in reader:
        date_time = datetime.strptime(row[0], "%Y-%m-%d")
        dew = row[4]

        date_times.append(date_time)
        max_dews.append(dew)


# 根据数据绘制图形
fig = plt.figure(dpi=128, figsize=(10, 6))
plt.plot(date_times, max_dews, c='red', alpha=0.5)
# plt.fill_between(dates, hights, lows, facecolor='blue', alpha=0.1)

# 设置图形的格式
plt.title("max_dew", fontsize=24)
plt.xlabel('', fontsize=16)
fig.autofmt_xdate()
plt.ylabel("Temperature (F)", fontsize=16)
plt.tick_params(axis='both', which='major', labelsize=16)

plt.show()

