import pandas as pd

read_file = pd.read_csv (r'FLATTENED_IMAGES.txt')
read_file.to_csv (r'FLATTENED_IMAGES.csv', index=None)