$(document).ready(function () {
    // Check (onLoad) if the cookie is there and set the class if it is
    if ($.cookie('highcontrast') == "yes") {
        $("body").addClass("highcontrast");
    }
    // When the element is clicked
    $("a.button-toggle-highcontrast").click(function () {
        if ($.cookie('highcontrast') == "yes") {
            $('body').removeClass('highcontrast');
            $.cookie("highcontrast", null, {
                path: '/'
            });
        } else {


            if ($.cookie('highcontrast') == "undefined" || $.cookie('highcontrast') == "no") {

                $.cookie('highcontrast', 'yes', {
                    expires: 7,
                    path: '/'
                });
                $("body").addClass("highcontrast");

            } else {

                $.cookie('highcontrast', 'yes', {
                    expires: 7,
                    path: '/'
                });
                $("body").addClass("highcontrast");

            }
        }

    });
    

});

