import numpy as np
import time

# FLATTENED_IMAGES
t1=time.time()
array_lst = np.loadtxt("FLATTENED_IMAGES.txt", np.float32)
t2=time.time()
print(array_lst)
print('\nShape: ',array_lst.shape)
print(f"Time took to read: {t2-t1} seconds.")
np.save('FLATTENED_IMAGES.npy', array_lst)


# CLASSIFICATIONS
t1=time.time()
array_lst = np.loadtxt("CLASSIFICATIONS.txt", np.float32)
t2=time.time()
print(array_lst)
print('\nShape: ',array_lst.shape)
print(f"Time took to read: {t2-t1} seconds.")
np.save('CLASSIFICATIONS.npy', array_lst)