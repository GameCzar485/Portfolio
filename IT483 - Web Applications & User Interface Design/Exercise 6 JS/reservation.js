$(document).ready(function() {
	var emailPattern = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b/;
}); // end ready


var $ = function (id) {
    return document.getElementById(id);
}

var processEntries = function () {
    var arDate = $("arrival_date").value;
    var nights = $("nights").value;
    var name = $("name").value;
    var email = $("email").value;
    var phone = $("phone").value;
    
    var arDatet = arDate.trim();
    var nightst = nights.trim();
    var namet = name.trim();
    var emailt = email.trim();
    var phonet = phone.trim();
    
    $("arrival_date").value = arDatet;
    $("nights").value = nightst;
    $("name").value = namet;
    $("email").value = emailt;
    $("phone").value = phonet;
    
    var nightsn = parseFloat(nightst);
    var isValid = true;
    
    var emailPattern = /\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}\b/;
    
    if (arDatet == "") {
        $("arDate_span").textContent = "This field is required.";
        isValid = false;
    }
    if (nightst == "") {
        $("nights_span").textContent = "This field is required.";
        isValid = false;
    }
    if (isNaN(nightsn) == true) {
        $("nights_span").textContent = "Must be a Number.";
        isValid = false;
    }
    if (namet == "") {
        $("name_span").textContent = "This field is required.";
        isValid = false;
    }
    if (emailt == "") {
        $("email_span").textContent = "This field is required.";
        isValid = false;
    }
    if (emailPattern.test(emailt) == false) {
        $("email_span").textContent = "Must be a valid email address.";
        isValid = false;
    }
    if (phonet == "") {
        $("phone_span").textContent = "This field is required.";
        isValid = false;
    }
    
    return isValid;
}

window.onload = function () {
    $("arrival_date").focus();
    $("reservation_form").onsubmit = processEntries;
}