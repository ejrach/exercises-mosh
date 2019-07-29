from django.contrib import admin
from .models import Product, Offer

class OfferAdmin(admin.ModelAdmin):
    list_display = ('code', 'discount')

class ProductAdmin(admin.ModelAdmin):
    list_display = ('name', 'price', 'stock')

#this is telling Django we want to manage our Product app within the admin panel.
#admin.site.register(Product)
admin.site.register(Offer, OfferAdmin)
admin.site.register(Product, ProductAdmin)