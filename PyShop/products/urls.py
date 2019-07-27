from django.urls import path
from . import views


# /products/1/detail
# /products/new

# map the root url of "products" to this function
urlpatterns = [
    path('',views.index),        #this represents the root of the products app
    path('new',views.new)
]