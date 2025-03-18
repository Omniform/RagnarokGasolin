// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    console.log($('#carouselwithIndicators').css('height')); // check the initial height of the carousel;

    // now apply this height as a max-height on all the image items; css will handle the rest;
    $('#carouselwithIndicators').find('.carousel-item img').css('max-height', $('#carouselwithIndicators').css('height'))
});