$(document).ready(function () {

    $(document).on("click", ".productdetail", function (e) {
        e.preventDefault();

        let url = $(this).attr("href");

        fetch(url).then(response => response.text())
            .then(data => {
                $(".modal-content").html(data);
                $('.pro-nav').slick({
                    slidesToShow: 4,
                    asNavFor: '.product-large-slider',
                    arrows: false,
                    focusOnSelect: true
                });

                $('.product-large-slider').slick({
                    fade: true,
                    arrows: false,
                    asNavFor: '.pro-nav'
                });


                $('.pro-qty').prepend('<span class="dec qtybtn">-</span>');
                $('.pro-qty').append('<span class="inc qtybtn">+</span>');
                $('.qtybtn').on('click', function () {
                    var $button = $(this);
                    var oldValue = $button.parent().find('input').val();
                    if ($button.hasClass('inc')) {
                        var newVal = parseFloat(oldValue) + 1;
                    } else {
                        // Don't allow decrementing below zero
                        if (oldValue > 0) {
                            var newVal = parseFloat(oldValue) - 1;
                        } else {
                            newVal = 0;
                        }
                    }
                    $button.parent().find('input').val(newVal);
                });

                $('.img-zoom').zoom();



                $("#productQuickModal").modal("show")

            })
    })

    $(document).on("click", ".addToBasket", function (e) {
        e.preventDefault();
        let url = $(this).attr("href");
        fetch(url).then(response => response.text()).then(data => {
            $(".minicart-content-box").html(data);
        })

    })
    $(document).on("click", "#addbasketbtn", function (e) {
        e.preventDefault()

        let url = $("#basketform").attr("action")
        let count = $("#productcount").val();
        let selectColor = $("#selectColor").val();
        let selectSize = $("#selectSize").val();
        console.log(selectColor)
        console.log(selectSize)
        url = url + "?count=" + count +"&colorid=" + selectColor +"&sizeid=" +selectSize;
        fetch(url).then(response => {
            return response.text();
        }).then(data => {
            $(".minicart-content-box").html(data)

        })
    })
    //$(document).on("click", ".addtobasketcart", function (e) {
    //    e.preventDefault();
    //    let url = $(this).attr("href");
    //    fetch(url).then(response => response.text()).then(data => {
    //        $(".minicart-content-box").html(data);
    //    })
    //})

    $(document).on("click", ".basketUpdate", function (e) {
        e.preventDefault();
        let url = $(this).attr("href");
        let color = $(this).parent().parent().parent().find(".color").text()
        let size = $(this).parent().parent().parent().find(".size").text()

        let count = $(this).parent().find(".countInp").val();
        let id = 0;

        if ($(this).hasClass("subCount")) {
            if (count != 1) {
                count--;
            }
            id = $(this).next().attr("data-id");
        }
        else if ($(this).hasClass("addCount")) {
            count++;
            id = $(this).prev().attr("data-id");
        }

        url = "Basket/Update" + "?id=" + id + "&count=" + count + "&color=" + color + "&size=" + size;


        fetch(url).then(response => {
            fetch("Basket/GetBasket").then(response => response.text()).then(data => $(".minicart-content-box").html(data))
            return response.text()

        }).then(data => $(".basketIndexPart").html(data))

        $(".countInp").val(parseFloat(count));
    })
    $(document).on("click", ".deletecard", function (e) {
        e.preventDefault();

        let url = $(this).attr("href");

        fetch(url).then(response => {
            fetch("Basket/GetBasket").then(response => response.text()).then(data => $(".minicart-content-box").html(data))

            return response.text()
        }).then(data => $(".basketIndexPart").html(data))
    })

    $(document).on("click", ".deletebasket", function (e) {
        e.preventDefault();

        let url = $(this).attr("href");

        fetch(url).then(response => {
            fetch("Basket/GetCard").then(response => response.text()).then(data => $(".basketIndexPart").html(data))

            return response.text()
        }).then(data => $(".minicart-content-box").html(data))
    })



})