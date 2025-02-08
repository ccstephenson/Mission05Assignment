$(document).ready(function() {
    $("#calculate").click(function() {
        var hours = parseFloat($("#hours").val());
        if (isNaN(hours) || hours <= 0) {
            alert("Please enter a valid number of hours.");
            return;
        }
        var rate = 20;
        var total = hours * rate;
        $("#total").text("$" + total.toFixed(2));
    });
});