var basket =document.querySelector(".basket");
basket.addEventListener("click",function(e){
    e.preventDefault();
    var basketfor=document.querySelector(".forbasket");
   basketfor.style.opacity="1";
    basketfor.style.visibility="visible";
    basketfor.style.right="1%"
})
var closebasket=document.querySelector(".closebasket");
closebasket.addEventListener("click",function(e){
    e.preventDefault();
    var basketfor= document.querySelector(".forbasket");
    basketfor.style.visibility="hidden";
    basketfor.style.right="-100%";
    basketfor.style.opacity="0";
})