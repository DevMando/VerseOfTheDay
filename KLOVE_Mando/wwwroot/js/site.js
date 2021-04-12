/*
 *  Author: Armando Fernandez
 *  Date: 4/11/2021
 *  Project: KLOVE Verse Sample Project - Interview
 * 
 * */

let payLoad;
let favorites = [];


// When the page loads, store the verses in JS, to reference when the user favorites the verses.
// The favorited verses will then be POSTED to another MVC route in, which then we can store to the databse using Entity.
$(document).ready(function () {
    payLoad = JSON.parse($('#verses').val());
    $('[data-toggle="tooltip"]').tooltip();
});

function updateFavorites(Id, isFavorite) {
    console.log(`${Id} : ${isFavorite}`);
    let newValue;
    let element = document.getElementById(Id);

    if (isFavorite === "false") {
        newValue = true;
        favorites.push(Id);
        element.classList.remove("btn-outline-danger");
        element.classList.add("btn-danger");
    } else {
        newValue = false;
        favorites = favorites.filter((c) => c != Id);
        element.classList.add("btn-outline-danger");
        element.classList.remove("btn-danger");
    }
    element.value = newValue.toString(); 

    // Update toast.
    if (favorites.length) {
        $('.toast').toast({ autohide: false });
        $('.toast').toast('show');
    } else {
        $('.toast').toast('hide');
    }

    // Update payload with favorites.
    let favoriteList = payLoad.filter((c) => favorites.includes(c.Id));
    $("#favorites").val(JSON.stringify(favoriteList));
}

$(".favTotal").click(function () {
    var currentLikes = $(".faveTotalValue").text;
    var totalLikes = (parseInt(currentLikes, 10) + 1);
    $(".faveTotalValue").text = totalLikes;
});


(function ($) {
    // I found this solution JS code online and applied it to the toast component.
    var element = $('.follow-scroll'),
        originalY = element.offset().top;
    var topMargin = 20;
    element.css('position', 'relative');
    element.css('z-index', '999999');

    $(window).on('scroll', function (event) {
        var scrollTop = $(window).scrollTop();

        element.stop(false, false).animate({
            top: scrollTop < originalY
                ? 0
                : scrollTop - originalY + topMargin
        }, 100);
    });
})(jQuery);