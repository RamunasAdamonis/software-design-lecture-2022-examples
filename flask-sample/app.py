from flask import Flask, render_template      
import pyodbc
import os
from dotenv import load_dotenv
import csv
  
app = Flask(__name__)  
load_dotenv()
 
def try_get_data():  
    try:
        return get_data()
    except:
        return None

def get_data():

    products = []

    with open('products.csv', newline='') as csvfile:
        reader = csv.DictReader(csvfile)
        for row in reader:
            products.append({
                'id': int(row['id']), 
                'name': row['name'], 
                'description': row['description'], 
                'imageUrl': row['imageUrl'] 
                })
    return products

def get_status():  
    return {'žinutė': 'Viskas veikia!'}

@app.route('/')   
def home():  
    return render_template("home.html")

@app.route('/produktai')   
def products(): 

    products = try_get_data()

    if products == None:
        return render_template("nothing.html")

    return render_template("products.html", products = products)

@app.route('/produktas/<id>')
def product(id):
    
    try:
        product_id = int(id)
    except ValueError:
        print('cannot parse id')
        return render_template("404.html")

    products = try_get_data()
    print(products)
    print(product_id)

    product = next(filter(lambda product: product['id'] == product_id, products), None)

    print(product)

    if (product):
        return render_template("product_details.html", product = product)
    
    return render_template("404.html")

@app.route('/info')   
def info(): 

    info = get_status()

    return render_template("info.html", info = info)

@app.errorhandler(404)
def handle_404(e):
    return render_template("404.html")

if __name__ =='__main__':  
    app.run(debug = True)  