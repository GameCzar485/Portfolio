$(document).ready(function() {
    var runCount = 0.00;
    
    $("#espresso").click(
    function(event) {
        var newVal = $("#placetext").val() + "$1.95 - Espresso\n";
        $("#placetext").text(newVal);
        runCount = runCount + 1.95;
        var count = runCount.toString();
        $("#total").text("Total: $" + count);
    });
    
    $("#latte").click(
    function(event) {
        var newVal = $("#placetext").val() + "$2.95 - Latte\n";
        $("#placetext").text(newVal);
        runCount = runCount + 2.95;
        var count = runCount.toString();
        $("#total").text("Total: $" + count);
    });
    
    $("#cappuccino").click(
    function(event) {
        var newVal = $("#placetext").val() + "$3.45 - Cappuccino\n";
        $("#placetext").text(newVal);
        runCount = runCount + 3.45;
        var count = runCount.toString();
        $("#total").text("Total: $" + count);
    });
    
    $("#coffee").click(
    function(event) {
        var newVal = $("#placetext").val() + "$1.75 - Drip Coffee\n";
        $("#placetext").text(newVal);
        runCount = runCount + 1.75;
        var count = runCount.toString();
        $("#total").text("Total: $" + count);
    });
    
    $("#biscotti").click(
    function(event) {
        var newVal = $("#placetext").val() + "$1.95 - Biscotti\n";
        $("#placetext").text(newVal);
        runCount = runCount + 1.95;
        var count = runCount.toString();
        $("#total").text("Total: $" + count);
    });
    
    $("#scone").click(
    function(event) {
        var newVal = $("#placetext").val() + "$2.95 - Scone\n";
        $("#placetext").text(newVal);
        runCount = runCount + 2.95;
        var count = runCount.toString();
        $("#total").text("Total: $" + count);
    });
    
    
    $("#clear").click(
    function(event) {
        $("#total").text("Total: $0.00");
        $("#placetext").text("");
        runCount = 0.00;
    });
});
