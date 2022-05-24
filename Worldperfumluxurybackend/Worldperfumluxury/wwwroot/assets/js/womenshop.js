// SEARCH

function toggleShow () {
    var el = document.getElementById("box");
    el.classList.toggle("show");
  }
(function ($) {

  $(document).ready(function () {
    // Pause hero carousel
    $('.hero-carousel').carousel('pause');
  });

  $(document).ready(function(){
    $(".owl-carousel").owlCarousel();
  });

})(jQuery);