from django.http import HttpResponse
from django.shortcuts import render
from .models import Product


# The '/products' page maps 'index'
# /products -> index

# The '/products/new' page maps to 'new'
# /products/new -> new

# These functions below are defined by the user.

# - Index will be the main page of the 'products' page.
def index(request):
    products = Product.objects.all()
    return render(request, 'index.html', {'products':products})


# - new will be the page browsed to at '/products/new' page.
def new(request):
    return HttpResponse('New Products')


