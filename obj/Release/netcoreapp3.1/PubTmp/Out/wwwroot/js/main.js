//Cart storage 
var cartId = "cart";

var localAdapter = {
	saveCart: function (object) {
		var stringified = JSON.stringify(object);
		localStorage.setItem(cartId, stringified);
		return true;
	},
	getCart: function () {
		if (localStorage.getItem(cartId) != undefined) {
			return JSON.parse(localStorage.getItem(cartId));
		}
		else {
			return null;
        }
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
		item["featureOne"] = document.getElementById("featureOne").checked;
		item["featureTwo"] = document.getElementById("featureTwo").checked;
		item["featureThree"] = document.getElementById("featureThree").checked;
		item["Path"] = path;
		item["Title"] = path.substring(path.lastIndexOf("\\") + 1, path.lastIndexOf("_"));
		//Fix choosing the same type of curtain leading to mutiple ids that are the same
		item["Id"] = item.Title + item.orderHeight + item.orderWidth + item.orderColor;
		return item;
	},
	updateView: function () {
		var items = storage.getCart();
		var compiled = "";
		for (var i = 0; i < items.length; i++) {
			compiled +=
				'<div class="top-cart item">' +
					'<div class="top-cart-item-image border-0"><img src="' + items[i].Path + '"/></div>' +
					'<div class="top-cart-item-desc">' +
						'<div class="top-cart-item-desc-title">' +
							'<a class="fw-medium">' + "Color:" + items[i].orderColor + " Room:" + items[i].orderRoom + '</p>' +
							'<div class="d-flex mt-2" data-id="' + items[i].Id + '">' +
								'<a href="#" data-toggle="modal" data-target="#modal" id="editBtn" class="fw-normal text-black-50 text-smaller"><u>Edit</u></a>' +
								'<a href="#" id="removeBtn" class="fw-normal text-black-50 text-smaller ms-3"><u>Remove</u></a>' +
							'</div>' +
						'</div>' +
					'</div>' +
				'</div>';
		}
		this.setHtml('cartItems', compiled);
		javascript: document.getElementById('top-cart-number').innerHTML = items.length.toString();
	},
	clearModal: function() {
		document.getElementById("orderWidth").value = "";
		document.getElementById("orderHeight").value = "";
		document.getElementById("orderColor").value = "None";
		document.getElementById("orderRoom").value = "None";
    },
	emptyView: function () {
		this.setHtml('cartItems', '<p>Your cart is empty</p>');
		javascript: document.getElementById('top-cart-number').innerHTML = '';
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
		storage.clearCart();
		helpers.emptyView();
	},
	addItem: function (item) {
		this.items.push(item);
		storage.saveCart(this.items);
		helpers.updateView();
	},
	removeItem: function (object) {
		var id = object.getAttribute("data-id");
		for (var i = 0; i < this.items.length; i++) {
			var _item = this.items[i];
			if (id == _item.Id) {
				this.items.splice(i, 1);
			}
		}
		storage.saveCart(this.items);
		if (this.items.length != 0) {
			helpers.updateView();
		}
		else {
			helpers.emptyView();
		}
		location.reload();
	},
	removeItemId: function (id) {
		for (var i = 0; i < this.items.length; i++) {
			var _item = this.items[i];
			if (id == _item.Id) {
				this.items.splice(i, 1);
			}
		}
		storage.saveCart(this.items);
		location.reload();
    },
	editItem: function (object) {
		var id = object.getAttribute("data-id");
		var index;
		for (index = 0; index < this.items.length; index++) {
			var _item = this.items[index];
			if (id == _item.Id) {
				var item = this.items[index];
				openDialogue(item["Path"]);
				document.getElementById("orderWidth").value = item["orderWidth"];
				document.getElementById("orderHeight").value = item["orderHeight"];
				document.getElementById("orderColor").value = item["orderColor"];
				document.getElementById("orderRoom").value = item["orderRoom"];
				if (item["featureOne"]) {
					document.getElementById("featureOne").setAttribute("selected", "selected");
				}
				else if (item["featureTwo"]) {
					document.getElementById("featureTwo").setAttribute("selected", "selected");
				}
				else if (item["featureThree"]) {
					document.getElementById("featureThree").setAttribute("selected", "selected");
				}
				break;
            }
		}
		document.getElementById("modal").setAttribute("data-id", "edit");
		document.getElementById("modal").setAttribute("data-name", id);
    }
};

document.addEventListener("DOMContentLoaded", function () {
	if (storage.getCart() != null && storage.getCart().length != 0) {
		cart.setItems(storage.getCart());
		helpers.updateView();
	} else {
		helpers.emptyView();
	}
	var removeBtns = document.querySelectorAll('#removeBtn');
	[].forEach.call(removeBtns, function (removeBtn) {
		removeBtn.addEventListener('click', function (e) {
			cart.removeItem(this.parentNode);
			listLoadCart();
		});

	});

	var editBtns = document.querySelectorAll('#editBtn');
	[].forEach.call(editBtns, function (editBtn) {
		editBtn.addEventListener('click', function (e) {
			cart.editItem(this.parentNode);
			listLoadCart();
		});
	});

	listLoadCart();

	document.getElementById("submitBtn").addEventListener('click', function (e) {
		var product = document.querySelectorAll('#orderForm input, select');
		var item = helpers.itemData(product);
		if (document.getElementById("modal").getAttribute("data-id") == "submit") {
			cart.addItem(item);
		}
		else if (document.getElementById("modal").getAttribute("data-id") == "edit") {
			cart.removeItemId(document.getElementById("modal").getAttribute("data-name"));
			cart.addItem(item);
			document.getElementById("modal").setAttribute("data-id", "submit");
			document.getElementById("modal").setAttribute("data-name", "");
        }
	});

	if (document.getElementById("sendBtn") != null) {
		document.getElementById("sendBtn").addEventListener('click', function (e) {
			var email = document.getElementById("email").value;
			var phoneNum = document.getElementById("phoneNum").value;
			$.ajax({
				type: "POST",
				url: "/api/Item/CurtainCheckoutAPI?Cart=" + localStorage.getItem(cartId) + "&Email=" + email + "&PhoneNum=" + phoneNum,
				//data: { Cart: localStorage.getItem(cartId), Email: email, PhoneNum: phoneNum },
				//data: { Email: 'test' },
				dataType: "JSON",
				//headers: {"Content-Type":"application/x-www-form-urlencoded"},
				//contentType: "application/x-www-form-urlencoded",
				//contentType: "application/json",
				success: function (result) {
				},
				error: function (xhr, status, error) {
				},
				beforeSend: function () {
				},
				complete: function () {
				}
			});
			storage.clearCart();
		});
	}
});

function listLoadCart() {
	var items = storage.getCart();
	if (items != null) {
		if (items.length != 0 && document.getElementById("orderList") != null) {
			var compiled = "";
			for (var i = 0; i < items.length; i++) {
				compiled +=
					'<li class="list-group-item">' +
					'<div class="media align-items-lg-center flex-column justify-content-center flex-lg-row p-3">' +
					'<div class="media-body order-2 order-lg-1">' +
					'<h4 class="mt-0 font-weight-bold mb-2">' + items[i].Title + '</h4>' +
					'<p class="fw-medium">' + "Width: " + items[i].orderWidth + " Height: " + items[i].orderHeight + " Color: " + items[i].orderColor + " Room: " + items[i].orderRoom + '</p>' +
					'</div><img src="' + items[i].Path + '" width="100" height="100" class="ml-lg-5 order-1 order-lg-2">' +
					'</div>' +
					'</li>';
			}
			compiled +=
				'<li class="list-group-item">' +
				'<div class="d-flex mt-2">' +
				'<form class="row" id="orderForm" action="" novalidate="novalidate">' +
				'<div class="col-6 form-group">' +
				'<label>Email</label>' +
				'<input type="email" name="email" id="email" class="form-control required">' +
				'</div>' +
				'<div class="col-6 form-group">' +
				'<label>Phone Number</label>' +
				'<input type="tel" name="phoneNum" id="phoneNum" pattern="[0-9]{3}-[0-9]{3}-[0-9]{4}" class="form-control required">' +
				'</div>' +
				'<div class="col-12">' +
				'<br>' +
				'<button value="send" id="sendBtn" type="submit" class="button button-large fw-normal form-control bg-color">Send Order</button>' +
				'</div>' +
				'</form>' +
				'</div>' +
				'</li>';
			document.getElementById("orderList").innerHTML = compiled;
		}
		else {
		}
	}
}

// Retrives item choices and displays in the modal
function openDialogue(path) {
	helpers.clearModal();
	document.getElementById("CurtainImg").src = path;
	document.getElementById("CurtainImg").alt = path;
	let itemName = path.substring(path.lastIndexOf("\\") + 1, path.lastIndexOf("_"));
	document.getElementById("orderColor").options.length = 0;
	document.getElementById("curtainTitle").innerHTML = itemName;
	$.ajax({
		type: "GET",
		url: "/api/Item?ItemName=" + itemName,
		contentType: "application/json",
		success: function (result, status, xhr) {
			var s = '<option value="none" selected disabled hidden>Select One</option>';
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
