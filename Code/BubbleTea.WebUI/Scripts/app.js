
var CartNamespace = {
};

var Loading = [{ "name": "Loading...", "id": 0 }];

var Product = function (id, name, price, flavor, toppings) {
    this.Id = ko.observable(id);
    this.Name = ko.observable(name);
    this.Price = ko.observable(price);

    this.flavor = ko.observable(flavor);    //Dummy observable, Will be removed in conversion
    this.toppings = ko.observableArray([]); //Dummy observable, Will be removed in conversion
};

// Exclude properties when calling toJson
Product.prototype.toJSON = function () {
    var copy = ko.toJS(this); //easy way to get a clean copy
    delete copy.flavor;
    delete copy.toppings;
    //Could remove more fields to optimize as server side would know price, name etc.
    return copy;
};


//Each line in the shopping cart
var CartItem = function (product, quantity, flavor, toppings) {
    var self = this; // Scope Trick

    self.product = ko.observable(product);
    self.quantity = ko.observable(quantity || 1);
    self.flavor = ko.observable(flavor);
    self.toppings = ko.observableArray(toppings);
    self.size = ko.observable();

    self.cost = ko.computed(function () {
        return self.product().Price() * self.quantity();
    });
};

// ViewModel class also referenced as $root
var ViewModel = function () {
    var self = this; //Assign self to this

    //Data observables used to store products and customizations
    self.products = ko.observableArray();
    self.flavorList = ko.observableArray(Loading);
    self.toppingList = ko.observableArray([]);
    self.sizeList = ko.observableArray([{ "Name": "L", "Id": "L" }, { "Name": "M", "Id": "M" }, { "Name": "S", "Id": "S" }]); //Static assuming this wont change much

    //Observables
    self.ShippingTotal = ko.observable(5.50); //Const value

    //Shopping cart lines containing CarItem
    self.lines = ko.observableArray();
    
    //Computed
    self.subtotal = ko.computed(function () {
        var subtotal = 0;
        $(self.lines()).each(function (index, item) {
            subtotal += item.cost();
        });
        return subtotal;
    });

    //Computed
    self.grandTotal = ko.computed(function () {
        return self.ShippingTotal() + self.subtotal();
    });

    //Add line to cart
    self.addToCart = function (product, event) {
        //Add to cart button pressed
        //Create new cart item with default qty 1
        var item = new CartItem(product, 1, product.flavor(), product.toppings());

        // Add the CartItem to lines
        self.lines.push(item);
    };

    //Remove line from cart
    self.removeFromCart = function (cart_item, event) {
        //Removes an item from cart
        self.lines.remove(cart_item);
    };

    //Send to server
    self.submit = function () {
        //Send cart data to server

        //Selective way to send data (ref. knockoutjs)
        //var data = $.map(self.lines(), function (line) {
        //    return line.product() ? {
        //        productName: line.product().Name,
        //        quantity: line.quantity()
        //    } : undefined
        //});
        var jsonData = ko.toJSON(self.lines());
        alert("Ajax post to server:\n" + jsonData);
    };

};


//Load products dynamically using ajax requests
CartNamespace.LoadData = function (args) {

    //Load products
    $.ajax({
        url: '/Data/GetProducts',
        type: "GET",
        cache: true,
        success: function (data) {
            //console.log(JSON.stringify(data));
            ViewModel.products.removeAll();
            for (var i = 0, j = data.length; i < j; i++) //Will fail otherwise as not all fields are represented
                ViewModel.products.push(new Product(data[i].Id, data[i].Name, data[i].Price));
        }
    });

    //Load flavorList
    //var flavorList = [{ "name": "Lemon", "id": 1 }, { "name": "Passionfruit", "id": 2 }, { "name": "Yogurt", "id": 3 }];
    $.ajax({
        url: '/Data/GetFlavors',
        type: "GET",
        /*contentType: "application/json; charset=utf-8",*/
        success: function (data) {
            //console.log(JSON.stringify(data));
            ViewModel.flavorList(data);
        }
    });

    //Load flavorList
    //var ToppingList = [{ "name": "Boba", "id": 1 }, { "name": "Red Bean", "id": 2 }, { "name": "Ai-Yu Jelly", "id": 3 }, { "name": "Basil Seeds", "id": 4 }];
    $.ajax({
        url: '/Data/GetToppings',
        type: "GET",
        success: function (data) {
            //console.log(JSON.stringify(data));
            ViewModel.toppingList(data);
        }
    });


};



CartNamespace.init = function (args) {

    //Init viewmodel
    window.ViewModel = new ViewModel();

    //Load data:
    //This method is not the most optimal with 3 different GET requests but works as a showcase of dynamic data load
    CartNamespace.LoadData();

    //Apply bindings
    ko.applyBindings(window.ViewModel);
    
};


