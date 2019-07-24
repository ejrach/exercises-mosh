#Package is a container for multiple modules, (or a directory or folder)

# How to create a package:
# 1. Create a folder in your project directory, i.e. "ecommerce" 
# 2. In that folder, create a new file and name it "__init__.py".
#       When python sees that file, it treats the directory as a package
# 3. Create another file in that directory called "shipping.py"
# 4. To import "shipping", you need to prefix it with the name of the package, i.e. "ecommerce" #
# #

#This imports only 1 method
#from ecommerce.shipping import calc_shipping

#This imports 2 specific methods
#from ecommerce.shipping import calc_shipping, calc_tax

#This imports the entire module
from ecommerce import shipping

shipping.calc_shipping()