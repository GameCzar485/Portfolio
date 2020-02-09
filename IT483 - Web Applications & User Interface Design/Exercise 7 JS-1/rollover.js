$(document).ready(function() {
    $('p').hide();
    $('li').hover( 
        function () {
            $(this).children('p').show();
        },
        function () {
            $(this).children('p').hide();
    });
}); // end ready