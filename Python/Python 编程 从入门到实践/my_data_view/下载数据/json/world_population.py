import json

filename = 'population_data.json'
with open(filename) as f:
    pop_data = json.load(f)

for pop_dict in pop_data:
    if pop_dict['Year'] == '2010':
        country_name = pop_dict['Country Name']
        population = int(float(pop_dict['Value']))  # 不能直接把包含小数点的字符串转换为整数
        print(country_name + ":" + str(population))