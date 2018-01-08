
function getReceipt(){
	var text = "<h5> You Ordered: </h5>";
    var countItem = 0;
	var subTotal = 0;
	var sizeArray = document.getElementsByClassName("size");
	var sizePrice;
	for (i=0; i < sizeArray.length; i++){
		if(sizeArray[i].checked){
			 var selectedSize = sizeArray[i].value;
			 text = text + selectedSize + "<br>";
		}
		if(selectedSize == "Personal Size"){
			sizePrice = 6;
		}else if (selectedSize == "Medium Size"){
			sizePrice = 10;
		}else if (selectedSize == "Large Size"){
			sizePrice = 14;
		}else if (selectedSize == "Extra Large Size"){
			sizePrice = 16;
		}
	subTotal = sizePrice;
	countItem = sizePrice;
	getMeat(text,countItem,subTotal);
	};
	
	function getMeat(text,countItem,subTotal) {
	var subTotal_meat = 0;
	var selectedMeat = [];
	var countMeat = 0;
	var meatArray = document.getElementsByClassName("meat");
	for (var j = 0; j < meatArray.length; j++) {
		if (meatArray[j].checked) {
			selectedMeat.push(meatArray[j].value);
			text = text + meatArray[j].value +"<br>";
			 console.log("selected meat is: " + meatArray[j].value +"<br>");
             console.log("j = " + j);
	 //if (j > 1 )
		if (selectedMeat.length>1){
		countMeat = 1;
		}else
        countMeat = 0;
		
	 countItem = countItem + "<br>" +countMeat;
		
		}
	};
		
	var meatCount = selectedMeat.length;
	if (meatCount > 1 ) {
		subTotal_meat = (meatCount - 1);
	} else {
		subTotal_meat = 0;
	
	}

	
	subTotal = (subTotal + subTotal_meat);
	console.log("total selected meat items: "+subTotal_meat);
	console.log("meats are: "+text);
	console.log("Purchase Total: "+"$"+subTotal+".00");

	getVeggie(text,countItem,subTotal);
	};
	
	
	function getVeggie(text,countItem,subTotal){
		var subTotal_veggie = 0;
		var selectedVeggie = [];
		var countVeggie = 0;
		var veggieArray = document.getElementsByClassName("veggie");
		
		for (var g = 0; g < veggieArray.length; g++){
			if (veggieArray[g].checked){
				selectedVeggie.push(veggieArray[g].value);
				console.log("selected veggie item: ("+veggieArray[g].value+")");
				text = text + veggieArray[g].value + "<br>";
				console.log("g = " + g);
			 
				  if ( selectedVeggie.length > 1 ){
					countVeggie = 1;
					}else
					countVeggie = 0;
	 countItem = countItem + "<br>" +countVeggie;
		
			
			}
		};
		
		
		var veggieCount = selectedVeggie.length
		if(veggieCount > 1 ){
			subTotal_veggie = (veggieCount - 1 );
		} else {
			subTotal_veggie = 0;
		};
		console.log("total selected veggie items: "+subTotal_veggie);
		console.log("veggies are: "+text);
		console.log("veggiePrice: "+"$"+subTotal+".00");

		subTotal = (subTotal + subTotal_veggie);
		
		getCheese(text,countItem,subTotal);
	};
	function getCheese(text,countItem,subTotal){
		var subTotal_cheese = 0;
		var selectedCheese;
		var countCheese;
		var cheeseArray = document.getElementsByClassName("cheese");
		for (a = 0; a < cheeseArray.length; a++){
		if (cheeseArray[a].checked){
			selectedCheese = cheeseArray[a].value;
			text = text +  selectedCheese + "<br>";
			console.log("you selected cheese is: " + selectedCheese);
		};
		};
		if  (selectedCheese == "Extra Cheese"){
			subTotal_cheese = 3;
			
		}else{ 
			 subTotal_cheese = 0;
			 
	};
	console.log("cheesePrice is: $" +subTotal_cheese+ ".00");
	countCheese = subTotal_cheese;
	countItem = countItem +"<br>" + countCheese;
	
	subTotal = subTotal + subTotal_cheese;
	getSauce(text,countItem,subTotal);
	};
	
	function getSauce(text,countItem,subTotal){
		var subTotal_sauce = 0;
		var selectedSauce;
		var countSauce = 0;
		
		var sauceArray = document.getElementsByClassName("sauce");
		for (x = 0; x < sauceArray.length; x++){
		if (sauceArray[x].checked){
			selectedSauce = sauceArray[x].value;
			text = text +  selectedSauce + "<br>";
			console.log("you selected sauce is: " + selectedSauce);
		};
		};
			subTotal_sauce = 0;
            countSauce = 0;			
			 
	
	countItem = countItem +"<br>" + countSauce;
	console.log("your saucePrice is: " + subTotal_sauce);
	
	subTotal = subTotal + subTotal_sauce;
	getCrust(text,countItem,subTotal);
	};
	
	function getCrust(text,countItem,subTotal){
		var subTotal_crust = 0;
		var selectedCrust;
		var countCrust;
		var crustArray = document.getElementsByClassName("crust");
		for (y = 0; y < crustArray.length; y++){
		if (crustArray[y].checked){
			selectedCrust = crustArray[y].value;
			text = text +  selectedCrust + "<br>";
			console.log("you selected crust is: " + selectedCrust);
		}
		};
		
		if (selectedCrust == "cheese stuffed crust"){
			subTotal_crust = 3;
			
		}else{ 
			 subTotal_crust= 0;
			 
	};
	countCrust = subTotal_crust;
	console.log("you selected crust is: " + selectedCrust);
	
	countItem = countItem +"<br>" + countCrust;
	
	subTotal = subTotal + subTotal_crust;
			
			
    document.getElementById("showText").innerHTML = text;
	document.getElementById("subTotal").innerHTML = "<h5>Item price is: </h5>"  + countItem;
	document.getElementById("totalPrice").innerHTML = "<h5>Totalprice is </h5>"  +"$"+ subTotal + ".00";
};
};
	