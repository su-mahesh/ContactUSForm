// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
/*@using Microsoft.Extensions.Options;
@inject IOptions < ContactUSForm.Models.ReCaptchaSetting > ReCaptcha;
*/
var obj = ;
$(".modal-back").click(function (e) {
    if (e.target == this)
        closeSug();
})
$("#sugsub").click(function (e) {
    closeSug()
})
function closeSug(){
    $(".modal-back").hide();
}

$("#headline-sug").click(function () {
    $(".modal-back").show();
});
$('.sugcheck').on('change', function () {
    $('.sugcheck').not(this).prop('checked', false);
    if ($('.sugcheck:checked').attr("value")) {
        $("#sug-text").val($('.sugcheck:checked').attr("value"));
    }
    else {
        $("#sug-text").val("");
    }
});
$(".submit").click(function (e) {
    Submit(e);
})

function Submit(e) {   
    e.preventDefault();
   grecaptcha.ready(function () {
       grecaptcha.execute("6Lfqj8gaAAAAALROCgtKUeXHwg80qod5-NnrDnHL", { action: 'submit' }).then(function (token) {
            // Add your logic to submit to your backend server here.
       });
   });
}
