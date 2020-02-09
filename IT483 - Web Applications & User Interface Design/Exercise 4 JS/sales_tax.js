$ = function (id) {
    return document.getElementById(id);
}

processEntries = function() {
    var subtotal = parseFloat( $("subtotal").value );
    var tax_rate = parseFloat( $("tax_rate").value );
    var sales_tax;
    var total;
    var error = "";
    
    if (isNaN(subtotal) || subtotal <= 0 || subtotal > 10000) {
    	error = "Subtotal must be > 0 and < 10000";
    	$("subtotal").focus();
    }
    if (isNaN(tax_rate) || tax_rate <= 0 || tax_rate > 12) {
    	error = "Tax Rate must be > 0 and < 12";
    	$("tax_rate").focus();
    }
    if (error == "") {
        $("sales_tax").value = ((subtotal * tax_rate) / 100);
        $("total").value = parseFloat($("sales_tax").value) + parseFloat($("subtotal").value);
    }
    else {
    	alert("Subtotal must be > 0 and < 10000\nTax Rate must be > 0 and < 12");
    }
    movePointer($("subtotal"));
}

window.onload = function() {
    movePointer($("subtotal"));
    $("calculate").onclick = processEntries;
    $("clear").onclick = clearAll;
    $("subtotal").onclick = clearSubtotal;
    $("tax_rate").onclick = clearTaxRate;
    $("subtotal").focus();
}

var clearAll = function() {
    $("subtotal").value = "";
    $("tax_rate").value = "";
    $("sales_tax").value = "";
    $("total").value = "";
    movePointer($("subtotal"));
}

var clearSubtotal = function() {
    $("subtotal").value = "";
}

var clearTaxRate = function() {
    $("tax_rate").value = "";
}

var movePointer = function(a) {
    if (a.createTextRange) {
        var b = a.createTextRange();
        b.collapse(true);
        b.moveEnd('character', 1);
        b.moveStart('character', 1);
        b.select();
    }
    else if(a.setSelectionRange) {
        a.focus();
        a.setSelectionRange(1, 1);
    }
}
