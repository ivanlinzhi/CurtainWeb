//Cart storage 
var cartId = "cart";

var localAdapter = {
	saveCart: function (object) {
		var stringified = JSON.stringify(object);
		localStorage.setItem(cartId, stringified);
		return true;
	},
	getCart: function () {
		return JSON.parse(localStorage.getItem(cartId));
	},
	clearCart: function () {
		localStorage.removeItem(cartId);
	}
};

var storage = localAdapter;

var helpers = {
	getHtml: function (id) {
		return document.getElementById(id).innerHTML;
	},
	setHtml: function (id, html) {
		document.getElementById(id).innerHTML = html;
		return true;
	},
	itemData: function (object) {
		var item = Array.from(object).reduce((acc, input) => ({ ...acc, [input.id]: input.value }), {});
		var path = document.getElementById("CurtainImg").alt;
		item["Path"] = path;
		//Fix choosing the same type of curtain leading to mutiple ids that are the same
		item["Id"] = path.substring(path.lastIndexOf("\\") + 1, path.lastIndexOf("_"));
		return item;
	},
	updateView: function () {
		var items = storage.getCart();
		var compiled = "";
		for (var i = 0; i < items.length; i++) {
			compiled += '<div class="top-cart item">' +
				'<div class="top-cart-item-image border-0"><img src="' + items[i].Path + '"/></div>' +
				'<div class="top-cart-item-desc">' +
				'<div class="top-cart-item-desc-title">' +
				'<p class="fw-medium">' + "Width:" + items[i].orderWidth + "Height:" + items[i].orderHeight + '</p>' +
				'<div class="d-flex mt-2">' +
				'<a href="#" id="' + "E" + items[i].Id + '" class="fw-normal text-black-50 text-smaller"><u>Edit</u></a>' +
				'<a href="#" id="' + "R" + items[i].Id + '" class="fw-normal text-black-50 text-smaller ms-3"><u>Remove</u></a>' +
				'</div></div ></div>' +
				'</div >';
		}
		this.setHtml('cartItems', compiled);
	},
	emptyView: function () {
		this.setHtml('cartItems', '<p>Your cart is empty</p>');
	},
};

var cart = {
	items: [],
	getItems: function () {
		return this.items;
	},
	setItems: function (items) {
		this.items = items;
	},
	clearItems: function () {

		this.items = [];
		this.total = 0;
		storage.clearCart();
		helpers.emptyView();

	},
	addItem: function (item) {
		this.items.push(item);
		storage.saveCart(this.items);
		helpers.updateView();
	},
	removeItem: function (id) {
		for (var i = 0; i < this.items.length; i++) {
			var _item = this.items[i];
			if (id == _item.id) {
				items.splice(i, 1);
			}
		}
		storage.saveCart(this.items);
		helpers.updateView();
	}
};

document.getElementById("submitBtn").addEventListener('click', function (e) {
	var product = document.querySelectorAll('#orderForm input');
	var item = helpers.itemData(product);
	cart.addItem(item);
});

document.getElementById("clearBtn").addEventListener('click', function (e) {
	cart.clearItems();
});

// Retrives item choices and displays in the modal
function openDialogue(path) {
	document.getElementById("CurtainImg").src = path;
	document.getElementById("CurtainImg").alt = path;
	let itemName = path.substring(path.lastIndexOf("\\") + 1, path.lastIndexOf("_"));
	document.getElementById("orderColor").options.length = 0;
	$.ajax({
		type: "GET",
		url: "/api/Item?ItemName=" + itemName,
		contentType: "application/json",
		success: function (result, status, xhr) {
			var s = '<option value="-1">Select One</option>';
			$.each(result, function (i, item) {
				s += '<option value="' + item.strColor + '">' + item.strColor + '</option>';
			});
			$("#orderColor").html(s);
		},
		error: function (xhr, status, error) {
			console.log(xhr)
		}
	});
}