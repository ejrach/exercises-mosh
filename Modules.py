#There are two ways to import modules, as seen below. In each case the Modules_Converters
#module is a self defined module that you can use to store related functions in.
#
# if you do: "import Modules_Converters", then you actually import all methods
# if you do "from Modules_Converters import kg_to_lbs", thenn you only import that specific method

#1
import Modules_Converters
#2
from Modules_Converters import kg_to_lbs

#1
print(Modules_Converters.kg_to_lbs(70))
#2
print(kg_to_lbs(70)) 

